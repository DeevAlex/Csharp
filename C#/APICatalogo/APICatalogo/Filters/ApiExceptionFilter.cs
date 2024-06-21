using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace APICatalogo.Filters;

public class ApiExceptionFilter : IExceptionFilter
{

    private readonly ILogger<ApiExceptionFilter> _logger;

    public ApiExceptionFilter(ILogger<ApiExceptionFilter> logger)
    {
        _logger = logger;
    }

    public void OnException(ExceptionContext context) // é chamado automaticamente toda vez que acontecer uma exceção não tratada durante um processamento de um request http, o parametro context contém informações da exceçao e o contexto atual do request
    {
        _logger.LogError(context.Exception, "Ocorreu uma exceção não tratada"); // logando um erro

        context.Result = new ObjectResult("Ocorreu um problema ao tratar a sua solicitação") // definindo o resultado da execeção
        {

            StatusCode = StatusCodes.Status500InternalServerError,

        };

    }
}
