using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Controllers;

[Route("api/v{version:apiVersion}/teste")] // padrão URI
[ApiController]
[ApiVersion("2.0")]
public class TesteV2Controller : ControllerBase
{

    [HttpGet]
    public string GetVersion()
    {
        return "TesteV2 - GET - Api versão 2.0";
    }

}
