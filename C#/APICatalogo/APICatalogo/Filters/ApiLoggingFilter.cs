using Microsoft.AspNetCore.Mvc.Filters;

namespace APICatalogo.Filters;

// devemos implementar a interface IActionFilter, essa classe vai ser usada para executar ações especificas antes e depois de um metodo action
public class ApiLoggingFilter : IActionFilter
{
    
    // a interface ILogger aqui faz parte do sistema de registro, ela permite que nos registremos informações, mensagens e eventos no nosso caso aqui no output
    private readonly ILogger<ApiLoggingFilter> _logger;

    // injeção de dependencia do serviço ILogger
    public ApiLoggingFilter(ILogger<ApiLoggingFilter> logger)
    {
        _logger = logger;
    }

    // vai ser executado depois do metodo action
    public void OnActionExecuted(ActionExecutedContext context)
    {

        _logger.LogInformation("### Executando -> OnActionExecuted");
        _logger.LogInformation("################################################");
        _logger.LogInformation($"{DateTime.Now.ToLongTimeString()}");
        _logger.LogInformation($"ModelState: {context.ModelState.IsValid}");
        _logger.LogInformation("################################################");

    }

    // vai ser executado antes do metodo action
    public void OnActionExecuting(ActionExecutingContext context)
    {

        _logger.LogInformation("### Executando -> OnActionExecuting");
        _logger.LogInformation("################################################");
        _logger.LogInformation($"{DateTime.Now.ToLongTimeString()}");
        _logger.LogInformation($"ModelState: {context.HttpContext.Response.StatusCode}");
        _logger.LogInformation("################################################");

    }
}
