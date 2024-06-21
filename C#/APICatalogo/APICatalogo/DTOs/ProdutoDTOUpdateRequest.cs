using System.ComponentModel.DataAnnotations;

namespace APICatalogo.DTOs;

public class ProdutoDTOUpdateRequest : IValidatableObject
{

    // usando uma data annotation para fazer uma validação
    [Range(1, 9999, ErrorMessage = "Estoque deve estar entre 1 e 9999")]
    public int Estoque { get; set; }

    public DateTime DataCadastro { get; set; }

    // fazendo uma validação personalizada implementando a interface 'IValidatableObject'
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (this.DataCadastro.Date <= DateTime.Now.Date)
        {
            yield return new ValidationResult("A data deve ser maior que a data atual", [nameof(this.DataCadastro)]);
        }
        if (this.Estoque <= 0)
        {
            yield return new ValidationResult("O Estoque deve ser maior do que 0", [nameof(this.Estoque)]);
        }
    }
}
