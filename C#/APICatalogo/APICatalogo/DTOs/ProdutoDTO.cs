using System.ComponentModel.DataAnnotations;

namespace APICatalogo.DTOs;

public class ProdutoDTO : IValidatableObject
{

    public int ProdutoId { get; set; } // aqui será a chave primaria, tem que ser chamada ProdutoId ou Id

    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(80)]
    // [PrimeiraLetraMaiuscula] // nossa validação usando um atributo customizado, caso tenha uma validação a nivel do modelo e um atributo customizado, o atributo customizado vai ter preferencia em ser executado
    public string? Nome { get; set; }

    [Required]
    [StringLength(300, ErrorMessage = "A descrição deve ter no máximo {1} caracteres")]
    public string? Descricao { get; set; }

    [Required]
    public decimal Preco { get; set; }

    [Required]
    [StringLength(300, MinimumLength = 6)]
    public string? ImagemUrl { get; set; }

    public int CategoriaId { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {

        // se o valor da propriedade 'this.Nome' for nulo ou vazio se for diferente dessa condição entra no bloco de codigo
        if (!string.IsNullOrEmpty(this.Nome))
        {

            var primeiraLetra = this.Nome.ToString()[0].ToString();

            if (primeiraLetra != primeiraLetra.ToUpper())
            {

                // definindo a mensagem de erro e uma lista de membros que possui erros de validação (o operador nameof retorna o nome do tipo), o yield indica que o metodo ou o operador e um iterador e nos usamos o yield para retornar cada elemento individualmente (é um atalho de codigo)
                yield return new ValidationResult("A primeira letra do nome do produto deve ser maiúscula!", [nameof(this.Nome)]);

            }

        }

        if (this.Nome?.ToLower() == "string")
        {
            yield return new ValidationResult($"O nome não pode estar como '{this.Nome}'", [nameof(this.Nome)]);
        }

        if (this.Descricao?.ToLower() == "string")
        {
            yield return new ValidationResult($"A descrição não pode estar como '{this.Descricao}'", [nameof(this.Descricao)]);
        }

        if (this.ImagemUrl?.ToLower() == "string")
        {
            yield return new ValidationResult($"A imagem não pode estar como '{this.ImagemUrl}'", [nameof(this.ImagemUrl)]);
        }

        if (this.Preco <= 0 ||  this.Preco > 999999)
        {
            yield return new ValidationResult($"O Preço deve estar entre 1 a 100000", [nameof(this.Preco)]);
        }

    }

}
