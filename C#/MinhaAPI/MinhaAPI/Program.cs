var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Esses metodos são responsaveis por configurar os serviços, endPoints e middlewares da nossa aplicação WebAPI incluindo a configuração do swagger para a geração da documentação da API 
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); // Esse metodo é responsavel por redirecionar as requisicões HTTP para HTTPS

app.UseAuthorization(); // Esse metodo é responsavel por configurar a autenticação e autorização para a nossa aplicação

app.MapControllers(); // Esse metodo é responsavel por fazer o mapeamento dos controllers para os endPoints das rotas especificadas em cada um deles  

app.Run(); // Esse metodo é responsavel por iniciar a nossa aplicação e vai permitir que ela receba requisições HTTP

// Controlador:
// É uma classe que é responsavel por lidar com as requisições HTTP e atua como um intermediario entre as requisições feitas por clientes, e a logica d negócios que processa essas requisições

 