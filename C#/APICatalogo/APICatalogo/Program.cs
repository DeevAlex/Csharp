using APICatalogo.Context;
using APICatalogo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

// Ordem do fluxo dos middlewares:
// 1º Habilita Autenticação (Authentication)
// 2º Habilita a Verificação da Autenticação do usuario ele é quem vai delegar o acesso a um recurso (Authentication)
// 3º Verificação da Autenticação do usuario (MVC)

// builder representa uma instância de WebApplicationBuilder e possui uma propriedade Configuration que é uma instancia de IConfiguration
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Habilitar o serviço dos controladores no container DI nativo
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; // Vai ignorar quando ocorrer uma referencia ciclica
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Obtendo valores/informações do appsettings.json
var valor1 = builder.Configuration["chave1"];
var valor2 = builder.Configuration["secao1:chave2"];

// 1° Obter a string de conexão
string mySqlConnection = builder.Configuration.GetConnectionString("ConexaoPadrao");

// 2° Definir o contexto(AppDbContext) e vamos informar o provedor(UseMySql) e a string de conexão(mySqlConnection)
builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection)));
builder.Services.AddTransient<IMeuServico, MeuServico>(); // usando tempo de vida transient (implica que um novo objeto do meu serviço vai ser criado toda vez que for solicitado uma instacia desse serviço, isso significa que cada vez que um componente ou uma classe que solicitar essa dependencia o sistema de injeção de dependencia vai criar uma nova instancia do serviço), estamos informando nesse serviço toda vez que invocar a interface ele vai me resolver fornecendo a implementação dessa interface definada na classe concreta 'MeuServico.cs'

// desabilita o mecanismo de inferencia para injeção de dependencia nos controladores, caso estiver true o metodo GetSaudacaoSemFromServices não funciona mais, só funciona o metodo action com atributo [FromServices]
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.DisableImplicitFromServicesParameters = true;
});

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

app.UseAuthorization();

// Um request delegate é uma função que recebe um objeto de contexto do request HTTP e executa uma lógica especifica para esse request
app.Use(async (context, next) =>
{

    // adicionar o código antes do request
    await next(context);

    // adicionar o codigo depois do request

});

app.MapControllers(); // Inclui os endPoints dos metodos actions do controlador, usado para mapear qualquer atributo que possa existir nos controladores usando os atributos [Route] [httpGet]

// Aqui o metodo Run da instancia de app é usado para adicionar um middleware terminal ao pipe line de processamento do request, usamos o app.Run() quando desejamos encerrar o pipe line de middleware e gerar uma resposta para o request sem a necessidade de chamar os middlewares subsequentes
app.Run(async(context) =>
{
    await context.Response.WriteAsync("Middleware final");
});

app.Run();