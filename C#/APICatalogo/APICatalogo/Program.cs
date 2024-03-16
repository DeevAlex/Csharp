using APICatalogo.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(); // Habilitar o serviço dos controladores no container DI nativo

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 1° Obter a string de conexão
string mySqlConnection = builder.Configuration.GetConnectionString("ConexaoPadrao");

// 2° Definir o contexto(AppDbContext) e vamos informar o provedor(UseMySql) e a string de conexão(mySqlConnection)
builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection)));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); // Inclui os endPoints dos metodos actions do controlador

app.Run();
