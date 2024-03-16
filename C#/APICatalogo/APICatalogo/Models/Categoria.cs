using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models;

[Table("Categorias")] // não precisa porque já fizemos isso com o DbSet no AppDbContext
public class Categoria
{

    // EF Core Migrations -> É uma forma de versionar ou seja de manter o esquema de BD sincronizado com o modelo do EF Core preservando os dados existentes, Sempre que você alterar as classes do modelo dominio, precisará executar o Migrations para manter o esquema do BD atualizado
    // Como funciona:
    //                 Cria                   Migrations
    // Modelo Entidade   ->   Modelo do EF Core   ->   Banco de Dados

    // Comandos para aplicar o Migrations usando EF Core Tools:

    // Cria Script de Migração:
    // dotnet ef migrations add 'nome_da_migracao'
   
    // Remove o script de migração criado:
    // dotnet ef migrations remove 'nome_da_migracao'
    
    // Gera o BD e as tabelas com base no script
    // dotnet ef database update

    public Categoria() { 
        Produtos = new Collection<Produto>(); // é uma boa pratica inicializar a coleção, porque é responsabilidade da classe onde você define a propriedade do tipo coleção iniciar essa coleção
    }

    [Key] // Simboliza que esse atributo será uma chave primaria, só que não precisa pois o EF Core sabe que <NOME_DA_CLASSE>Id será uma PK 
    public int CategoriaId { get; set; }

    // O string? significa que é nullable porque o nullable está ativado fazendo assim que as propriedades por referencia tem que ser nullable
    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }

    [Required] // Indicando que a coluna vai ser NOT NULL
    [StringLength(300)] // Tamanho em bytes como 300
    public string? ImagemUrl { get; set; }

    // Definimos um relacionamento 1 para Muitos, Uma Categoria pode ter mais de um produto
    public ICollection<Produto>? Produtos { get; set; }
}
