using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Controllers;

[Route("api/v{version:apiVersion}/teste")] // padrão QueryString vai ser adicionado na url a query string ?api-version=<numero da versão>
[ApiController]
[ApiVersion("1.0", Deprecated = true)] // esse atributo  define a versão da api que esse controle atua e para definir uma sinalização que uma api como obsoleta ou depreciada -> [ApiVersion("1.0", Deprecated = true)]
public class TesteV1Controller : ControllerBase
{

    [HttpGet]
    public string GetVersion()
    {
        return "TesteV1 - GET - Api versão 1.0";
    }

}
