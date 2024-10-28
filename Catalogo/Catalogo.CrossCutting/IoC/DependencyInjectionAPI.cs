using Catalogo.Application.Interfaces;
using Catalogo.Application.Mappings;
using Catalogo.Application.Services;
using Catalogo.Domain.Interfaces;
using Catalogo.Infraestructure.Context;
using Catalogo.Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.CrossCutting.IoC;

public static class DependencyInjectionAPI
{

    // utilizando o container nativo de injeção de dependencia da ASP.NET Core para configurar o contexto como serviço, definir o provedor do banco de dados que está sendo utilizado
    public static IServiceCollection AddInfrastructureAPI(this IServiceCollection services, IConfiguration configuration)
    {

        //services.AddDbContext<ApplicationDbContext>(options => 
        //{
        //    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
        //});

        var mysqlConnection = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(mysqlConnection, ServerVersion.AutoDetect(mysqlConnection)));

        services.AddScoped<ICategoriaRepository, CategoriaRepository>(); // para registrar o serviço de ICategoria, de IProduto
        services.AddScoped<IProdutoRepository, ProdutoRepository>();
        services.AddScoped<IProdutoService, ProdutoService>();
        services.AddScoped<ICategoriaService, CategoriaService>();

        services.AddAutoMapper(typeof(DomainToDTOMappingProfile)); // e o mapeamento do automapper

        return services;

    }

}
