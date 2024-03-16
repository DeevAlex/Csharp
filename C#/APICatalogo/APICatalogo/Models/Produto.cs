using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models;

[Table("Produtos")]
public class Produto
{

    // Classes Anêmicas é quando não possui comportamento, apenas possui propriedades
    // Podemos realizar o MAPEAMENTO DAS CLASSES das entidades do dominio e gerar o banco de dados e as tabelas

    // Code-First - Primeiro criamos as ENTIDADES e a partir delas geramos o banco e as tabelas

    // O EF Core adota algumas CONVENÇÕES para realizar o mapeamento das entidades

    // Precisamos incluir as referencias: Pomelo.EntityFrameworkCore.MySql, Microsoft.EntityFrameworkCore.Design e Microsoft.EntityFrameworkCore.Tools

    // Data Annotations -> são um conjunto de atributos que podem ser aplicados a classes e seus membros para fornecer metadados sobre como esses recursos devem ser tratados pelo sistema, Ex.: [Key], Table("MOME_DA_TABELA"), [StringLength(XX), ErrorMessage="Mensagem"], [Column(TypeName="decimal(10, 2)")], entre outros . esse atributos são usados para realizar validações de entrada de dados e Influenciar o comportamento do modelo de dados. podemos usar os atributos annotations para validação de dados, Formatação e exibição de dados, Geração de codigo, Especificar o relacionamento entre as entidades, Sobreescrever as convenções do EF Core
    // O EF Core usa um conjunto de regras (convenção padrão) para criar e atualizar as tabelas e o esquema do banco de dados quando as migrações são aplicadas

    [Key]
    public int ProdutoId { get; set; } // aqui será a chave primaria, tem que ser chamada ProdutoId ou Id

    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }

    [Required]
    [StringLength(300)]
    public string? Descricao { get; set; }

    [Required]
    [Column(TypeName = "decimal(10, 2)")] // indica a precisão decimal com 10 digitos e 2 casas decimais
    public decimal Preco { get; set; }

    [Required]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }

    public float Estoque { get; set; }
    public DateTime DataCadastro { get; set; }


    // Incluimos uma propriedade CategoriaId que mapeia para a chave estrangeira no banco de dados e uma propriedade de navegação Categoria para indicar que um Produto está relacionado com uma Categoria
    public int CategoriaId { get; set; } // Mapeia
    public Categoria? Categoria { get; set; } // Relacionamento 

}
