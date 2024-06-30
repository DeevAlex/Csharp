using APICatalogo.Context;
using APICatalogo.DTOs.Mappings;
using APICatalogo.Filters;
using APICatalogo.Logging;
using APICatalogo.Models;
using APICatalogo.Repositories;
using APICatalogo.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Security.Claims;
using System.Text;
using System.Text.Json.Serialization;

// Ordem do fluxo dos middlewares:
// 1º Habilita Autenticação (Authentication)
// 2º Habilita a Verificação da Autenticação do usuario ele é quem vai delegar o acesso a um recurso (Authentication)
// 3º Verificação da Autenticação do usuario (MVC)

// builder representa uma instância de WebApplicationBuilder e possui uma propriedade Configuration que é uma instancia de IConfiguration
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Habilitar o serviço dos controladores no container DI nativo
builder.Services.AddControllers(options =>
{
    options.Filters.Add(typeof(ApiExceptionFilter));
}).AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; // Vai ignorar quando ocorrer uma referencia ciclica
}).AddNewtonsoftJson(); // devemos configurar o NewtonSoftJson aqui para usar os recursos desse pacote

// Habilitando o CORS no middleware usando uma politica nomeada ou uma politica padrão
var OrigensComAcessoPermitido = "_origensComAcessoPermitido";

builder.Services.AddCors(options =>
{
    // Restringe os requests CORS às origens especificadas na politica
    options.AddPolicy(name: OrigensComAcessoPermitido, policy => policy.WithOrigins("http://www.apirequest.io")); // essa politica está definindo qual origem vai poder ter acesso a nossa API, podemos colocar outras origens também, não pode ter a barra direita no final da url, Ex.: 'http://www.apirequest.io/'.
    //options.AddPolicy(name: OrigensComAcessoPermitido, policy => policy.AllowAnyOrigin()); // Permite requests CORS de todas as origens.
    //options.AddPolicy(name: OrigensComAcessoPermitido, policy => policy.WithOrigins("http://www.apirequest.io").AllowAnyMethod()); // Permite qualquer método HTTP (GET, POST, PUT, DELETE, PATCH, OPTIONS, HEAD, TRACE, CONNECT).
    //options.AddPolicy(name: OrigensComAcessoPermitido, policy => policy.WithOrigins("http://www.apirequest.io").WithMethods("GET", "POST")); // Restringe para os métodos HTTP (GET, POST).
    //options.AddPolicy(name: OrigensComAcessoPermitido, policy => policy.WithOrigins("http://www.apirequest.io").AllowAnyHeader()); // Permite todos os cabeçalhos.
    options.AddPolicy(name: OrigensComAcessoPermitido, policy => policy.WithOrigins("http://www.apirequest.io").WithHeaders("HeadersName.ContentType", "x-meu-header")); // Restringe o header ao especificado na politica CORS
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Adicionando o SwaggerGen ao Container DI
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo{ Title = "apicatalogo", Version = "v1" }); // titulo e a versão da API, o primeiro "v1" é a versão da documentação

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme() // adicionando uma definição de segurança, chamada "Bearer", para indicar que a nossa aplicação vai usar o Token JWT Bearer
    {
        Name = "Authorization", // o name especifica o nome do cabeçalho usado para enviar o token 
        Type = SecuritySchemeType.ApiKey, // indica que autenticação é feita por meio de uma chave de API
        Scheme = "Bearer", // especifica o Schema de autenticação que é o "Bearer" (O portador do token)
        BearerFormat = "JWT", // o formato do token vai ser o JWT
        In = ParameterLocation.Header, // especifica que o Token JWT deve ser incluido no request no header 
        Description = "Bearer JWT", // uma descrição que ira aparecer na interface do Swagger 
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement() // adicionando aqui um requisito de segurança para indicar que as operações da api requerem um Schema de segurança Bearer
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });

});

// Obtendo valores/informações do appsettings.json
var valor1 = builder.Configuration["chave1"];
var valor2 = builder.Configuration["secao1:chave2"];

// Definindo o esquema de autenticaçao JWT (Precisa instalar o pacote 'Microsoft.AspNetCore.Authentication.JwtBearer')
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin")); // adicionando uma politica, "AdminOnly" é o nome dela e na função lambda estamos definindo os requisitos que o usuario deve atender ele deve haver o perfil 'Admin'
    options.AddPolicy("SuperAdminOnly", policy => policy.RequireRole("Admin").RequireClaim("id", "macoratti")); // o metodo RequireClaim, exige que o usuario tenha uma claim especifica para acessar um recurso protegido
    options.AddPolicy("UserOnly", policy => policy.RequireRole("User"));
    options.AddPolicy("ExclusiveOnly", policy => policy.RequireAssertion(context => context.User.HasClaim(claim => claim.Type == "id" && claim.Value == "macoratti" || context.User.IsInRole("SuperAdmin")))); // RequireAssertion, permite definir uma expressão lambda e com uma condição customizada para autorização
});
//builder.Services.AddAuthentication("Bearer").AddJwtBearer(); // quando estamos utilizando o 'user-jwts'

// Configurando o Identity (Deve ser feito antes do Build()), IdentityUser (Representa os usuarios) - Foi trocado pelo 'ApplicationUser', IdentityRole (Representa as funções do usuario e informações do usuario relacionado aos perfis) são os perfis do Identity, AddEntityFrameworkStores (configura EF Core como mecanismo para armazenar os dados relacionado com a classe de contexto), AddDefaultTokenProviders (Adicionando os provedores de token padrão para lidar com operações relacionadas a autenticação) - NÃO PRECISAMOS DO IDENTITY PARA IMPLEMENTAR O TOKEN JWT, mas estamos fazendo para saber como usar o identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

// 1° Obter a string de conexão
string mySqlConnection = builder.Configuration.GetConnectionString("ConexaoPadrao");

//2° Definir o contexto(AppDbContext) e vamos informar o provedor(UseMySql) e a string de conexão(mySqlConnection)
builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection)));

// Habilitar e configurar a autenticação JWT Bearer na aplicação
var secretKey = builder.Configuration["JWT:SecretKey"] ?? throw new ArgumentException("Invalid secret key!");

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme; // Por padrão o sistema de autenticação vai usar Token JWT
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme; // O desafio é quando alguem tentar acessar um recurso protegido sem fornecer o token então a aplicação vai lançar o desafio que é solicitar as credenciais do usuario
}).AddJwtBearer(options =>
{
    options.SaveToken = true; // O token deve ser salvo após uma autenticação bem sucedida  
    options.RequireHttpsMetadata = false; // indica se é preciso https para trasmitir o Token (em produção é true)
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true, // define as configurações para validar o emissor a audiencia e a validade do Token 
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true, // valida a chave de assinatura do emissor
        ClockSkew = TimeSpan.Zero, // permite ajustar o tempo para tratar com algumas diferenças de tempo entre o servidor de autenticação e o servidor de aplicação (permite que não tenha um delay nesse tempo)
        ValidAudience = builder.Configuration["JWT:ValidAudience"],
        ValidIssuer = builder.Configuration["JWT:ValidIssuer"], // atribui valores a audiencia e o emissor
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)) // cria uma chave simetrica criada a partir da chave secreta (ela esta sendo codificada em bytes), ela vai servir para assinar o token na geração do mesmo
    };
});

//builder.Services.AddTransient<IMeuServico, MeuServico>(); // usando tempo de vida transient (implica que um novo objeto do meu serviço vai ser criado toda vez que for solicitado uma instacia desse serviço, isso significa que cada vez que um componente ou uma classe que solicitar essa dependencia o sistema de injeção de dependencia vai criar uma nova instancia do serviço), estamos informando nesse serviço toda vez que invocar a interface ele vai me resolver fornecendo a implementação dessa interface definada na classe concreta 'MeuServico.cs'

builder.Services.AddScoped<ApiLoggingFilter>();

builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>(); // definindo o tempo de vida do serviço, falando para o ContainerDI, toda vez que alguem referenciar 'ICategoriaRepository' você passa para ele a implementação definida em 'CategoriaRepository', o AddScoped significa que uma instancia de 'CategoriaRepository' vai ser criada uma vez para cada escopo de solicitação uma vez por escopo de request, então isso garante que o request HTTP vai receber uma instancia isolada da minha implementação concreta de repositorio, por isso podemos injeta-lo no controlador, isso só funciona por causa disso, já informei o meu ContainerDI, é ele quem vai me passar a instancia e vai fazer a injeção do repositorio no construtor e dai vou poder acessa-lo como mostrado anteriormente
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>)); // devemos fazer assim pois o AddScoped não permite que fornecemos argumentos genéricos
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// Registrando o serviço no Container DI
builder.Services.AddScoped<ITokenService, TokenService>();

// Habilita o sistema de Logging da API
builder.Logging.AddProvider(new CustomLoggerProvider(new CustomLoggerProviderConfiguration
{
    LogLevel = LogLevel.Information,
}));

// Para usar os mapeamentos criados na classe 'ProdutoDTOMappingProfile' devemos informar aqui, ele informa ao AutoMapper quais tipos da nossa aplicação contém perfis de mapeamento, 
builder.Services.AddAutoMapper(typeof(ProdutoDTOMappingProfile));

// desabilita o mecanismo de inferencia para injeção de dependencia nos controladores, caso estiver true o metodo GetSaudacaoSemFromServices não funciona mais, só funciona o metodo action com atributo [FromServices]
//builder.Services.Configure<ApiBehaviorOptions>(options =>
//{
//    options.DisableImplicitFromServicesParameters = true;
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage(); // middleware das paginas de exceção do desenvolvedor 
}

// A ordem em que os middlewares são configurados é importante ela determina como os requests HTTP são processadas no pipe line do middleware da aplicação
app.UseHttpsRedirection();

// middleware de autenticação deve vir antes do middleware de autorização
app.UseAuthentication();

app.UseStaticFiles();

app.UseRouting();

// deve estar entre esses dois middlewares e depois do middleware UseStaticFiles
app.UseCors(OrigensComAcessoPermitido); // habilitando o suporte CORS 

app.UseAuthorization();

// Um request delegate é uma função que recebe um objeto de contexto do request HTTP e executa uma lógica especifica para esse request
//app.Use(async (context, next) =>
//{

//    // adicionar o código antes do request
//    await next(context);

//    // adicionar o codigo depois do request

//});

app.MapControllers(); // Inclui os endPoints dos metodos actions do controlador, usado para mapear qualquer atributo que possa existir nos controladores usando os atributos [Route] [httpGet]

// Aqui o metodo Run da instancia de app é usado para adicionar um middleware terminal ao pipe line de processamento do request, usamos o app.Run() quando desejamos encerrar o pipe line de middleware e gerar uma resposta para o request sem a necessidade de chamar os middlewares subsequentes
//app.Run(async(context) =>
//{
//    await context.Response.WriteAsync("Middleware final");
//});

app.Run();




// Gerenciando tokens com dotnet user-jwts
// dotnet user-jwts create - Gera um token JWT(*) com um ID definido
// dotnet user-jwts list - Lista todos os tokens JWT emitidos
// dotnet user-jwts key - Obtem a chave de emissão do token JWT atual
// dotnet user-jwts remove ID - Excluir o token JWT emitido pelo seu ID
// dotnet user-jwts clear - Limpar todos os tokens JWT emitidos
// dotnet user-jwts key --reset -force - Redefine a chave de emissão do token JWT atualmente em uso
// Redefine a chave de emissão do token JWT

// (*) - Registra automaticamente um conjunto de números secretos < UserSecretsld> exigidos pelo
// Secret Manager no arquivo de projeto csproj e define as configurações de autenticação no arquivo
// appsettings.json para o desenvolvimento.



// Ordem dos Middlewares (Pipeline de processamento de request): 

// Request > ExceptionHandler > HSTS > HttpsRedirection > Static Files > Routing > CORS > Authentication > Authorization > Custom1 > Custom... > EndPoint - (Custom1 > Custom...) são middlewares customizados
// Response < ExceptionHandler < HSTS < HttpsRedirection < Static Files < Routing < CORS < Authentication < Authorization < Custom1 < Custom... < EndPoint