using System.ComponentModel.DataAnnotations;

namespace APICatalogo.Validations;


// Como vamos usar essa classe como atributo devemos colocar como sufixo a palavra 'Attribute' por convenção da plataforma e ela deve herdar da classe 'ValidationAttribute'
public class PrimeiraLetraMaiusculaAttribute : ValidationAttribute
{
    // devemos sobreescrever esse metodo IsValid
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {

        // value é o valor da propriedade onde vamos aplicar esse atributo
        // ValidationContext tras informação do contexto onde estamos executando a validação

        // como temos o [Required] na propriedade nome que já faz uma validação então vamos fazer um bypass e vamos para a nossa validação
        if (value == null || string.IsNullOrEmpty(value.ToString())) 
        {
            return ValidationResult.Success;
        }

        var primeiraLetra = value.ToString()[0].ToString();

        if (primeiraLetra != primeiraLetra.ToUpper()) 
        {

            return new ValidationResult("A primeira letra do nome do produto deve ser maiúscula!");

        }

        return ValidationResult.Success;

    }

}
