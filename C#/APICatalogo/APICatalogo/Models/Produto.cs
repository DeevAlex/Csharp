using APICatalogo.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace APICatalogo.Models;

// A classe produto representando o nosso modelo de dominio

[Table("Produtos")]
public class Produto : IValidatableObject // devemos implentar a interface 'IValidatableObject' para implementar a validação nesse modelo (a nivel de modelo)
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

    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(80)]
    // [PrimeiraLetraMaiuscula] // nossa validação usando um atributo customizado, caso tenha uma validação a nivel do modelo e um atributo customizado, o atributo customizado vai ter preferencia em ser executado
    public string? Nome { get; set; }

    [Required]
    [StringLength(300, ErrorMessage = "A descrição deve ter no máximo {1} caracteres")]
    public string? Descricao { get; set; }

    [Required]
    [Range(1, 10000, ErrorMessage = "O Preço deve estar entre {1} e {2}")]
    [Column(TypeName = "decimal(10, 2)")] // indica a precisão decimal com 10 digitos e 2 casas decimais
    public decimal Preco { get; set; }

    [Required]
    [StringLength(300, MinimumLength = 10)]
    public string? ImagemUrl { get; set; }

    public float Estoque { get; set; }
    public DateTime DataCadastro { get; set; }


    // Incluimos uma propriedade CategoriaId que mapeia para a chave estrangeira no banco de dados e uma propriedade de navegação Categoria para indicar que um Produto está relacionado com uma Categoria
    public int CategoriaId { get; set; } // Mapeia

    [JsonIgnore] // vai ignorar no JSON inves de mostrar o Produto e Categoria apenas vai mostrar Produto no JSON
    public Categoria? Categoria { get; set; } // Relacionamento 

    // essa validação é restrita apenas para esse modelo
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {

        // se o valor da propriedade 'this.Nome' for nulo ou vazio se for diferente dessa condição entra no bloco de codigo
        if (!string.IsNullOrEmpty(this.Nome))
        {

            var primeiraLetra = this.Nome.ToString()[0].ToString();

            if (primeiraLetra != primeiraLetra.ToUpper())
            {
                
                // definindo a mensagem de erro e uma lista de membros que possui erros de validação (o operador nameof retorna o nome do tipo), o yield indica que o metodo ou o operador e um iterador e nos usamos o yield para retornar cada elemento individualmente (é um atalho de codigo)
                yield return new ValidationResult("A primeira letra do nome do produto deve ser maiúscula!", new[] { nameof(this.Nome) });

            }

        }

        // validando a propriedade 'Estoque' e la em cima a propriedade 'Nome'
        if (this.Estoque <= 0)
        {
            yield return new ValidationResult("O estoque deve ser maior que zero", new[] { nameof(this.Estoque) });
        }

    }

}
