using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Domain.Validations;

internal class DomainExceptionValidation : Exception
{

    public DomainExceptionValidation(string error) : base(error) {}

    public static void When(bool hasError, string errorMessage)
    {
        if (hasError)
        {
            throw new DomainExceptionValidation(errorMessage);
        }
    }

}
