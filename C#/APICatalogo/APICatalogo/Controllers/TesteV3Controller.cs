using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Controllers
{
    [Route("api/teste")]
    [ApiController]
    [ApiVersion("3.0")]
    [ApiVersion("4.0")]
    public class TesteV3Controller : ControllerBase
    {

        [MapToApiVersion("3.0")] // esse atributo é usado para indicar explicitamente a versão da api para qual uma classe (o controlador em si) ou metodo de controlador esta destinado 
        [HttpGet]
        public string GetVersion3()
        {
            return "TesteV3 - GET - Api versão 3.0";
        }

        [MapToApiVersion("4.0")]
        [HttpGet]
        public string GetVersion4()
        {
            return "TesteV3 - GET - Api versão 4.0";
        }

    }
}
