using Microsoft.AspNetCore.Mvc;

namespace MinhaAPI.Controllers
{
    [ApiController] // esse ApiController aqui todo o controlador vai possuir esse atributo vai trazer com ele e vai oferecer e permitir que as nossas APIS utilizem uma serie de recursos que facilitam a construção e o funcionamento das APIS e também vai ajudar a distribuir e ajuda também a distinguir um controlador webApi de um controlador MVC. com ele vamos ter acesso a recursos de convenções de roteamento, o binding automatico, validação automatica, resposta num formato padrão, geração de documentação e varios outros recursos.   
    [Route("[controller]")] // esse Route aqui é a rota definida como um atributo que esta usando dentro de [] a palavra controller, isso significa que o nome do controlador antes do sufixo controller vai ser usado como rota base para acessarmos todos endPoints da API que é representado pelos verbos HTTP que esta sendo utilizado aqui, como o [HttpGet(Name = "GetWeatherForecast")]
    public class WeatherForecastController : ControllerBase // estamos herdando de ControllerBase, ele indica que o controlador vai lidar com requisições http e ele vai omitir as funcionalidades que dão suporte as Views (porque no controlador não tem views)
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger) // injeção de dependencia no construtor que são um recurso muito utilizado nas WebAPIs
        {
            _logger = logger; // Estamos permitindo que o nosso controlador registre logs de auditoria
        }

        // EndPoit
        [HttpGet(Name = "GetWeatherForecast")] // verbo HTTP GET, o parametro NAME esta dando um nome para a rota opcional, como é opcional o que vai valer é a rota definida aqui [Route("[controller]")], para deixar de ser opcional precisa tirar o Name = , dai se tirar-mos para testar esse metodo precisamos colocar <Endereço>/GetWeatherForecast e caso tenha o Name = devemos colocar <Endereço>/WeatherForecast que é nome do controller sem a parte Controller 
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        // Outro EndPoint, dai para podermos fazer uma requisção como não tem Name = "Um nome", a rota fica o nome do controller sem a palavra controller + o que esta no parametro, Ex.: /WeatherForecast/Teste
        [HttpGet("Teste")]
        public string GetSaudacoes()
        {
            return $"{DateTime.Now.ToShortDateString()} - Bem vindo(a) à MinhaAPI";
        }
    }
}
