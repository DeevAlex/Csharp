using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Context;

public class AppDbContext : DbContext
{

    // a ConnectionString vai no appsettings.json

    // DbContext - Representa uma sessão com o banco de dados sendo a ponte entre as entidades de dominio e o banco

    // o : base( options ) chama o construtor da classe base que é a 'DbContext' passando as configurações que vamos definir 
    public AppDbContext(DbContextOptions<AppDbContext> options) : base( options ) // esse parametro vai conter as opções de configuração que serão usadas para configurar o contexto do banco de dados como: string de conexão e outras configurações especificas do provedor do BD
    {
        
    }

    // DbContext - Representa uma sessão com o banco de dados sendo a ponte entre as entidades de dominio e o banco
    // DbSet<T> - Representa uma coleção de entidades no contexto que podem ser consultadas no banco de dados

    public DbSet<Categoria>? Categorias { get; set; } // podemos definir essas propriedades como nullable isso é util se quisermos garantir que a propriedade seja opcional
    public DbSet<Produto>? Produtos { get; set; }

}
