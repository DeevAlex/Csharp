using APICatalogo.Context;
using APICatalogo.DTOs;
using APICatalogo.DTOs.Mappings;
using APICatalogo.Models;
using APICatalogo.Pagination;
using APICatalogo.Repositories;
using APICatalogo.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using X.PagedList;

namespace APICatalogo.Controllers
{
    [EnableCors("OrigensComAcessoPermitido")] // habilitando o CORS nesse controlador, podemos habilitar um ou mais metodos action e desabilitar também, esse data annotaion com parametro define uma politca nomeada caso não tenha é default
    [EnableRateLimiting("fixedwindow")] // aplicando a limitação de taxa a todos os endpoints do controller
    [Route("[controller]")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class CategoriasController : ControllerBase
    {

        // Toda vez que implementamos Actions que recebem parâmetros estamos usando model binding
        // Para otimizar o desempenho da API use o metodo AsNoTracking, e nunca retorne todos os registros em uma consulta use o metodo Take(<quantidade>), Nunca retorne objetos relacionados sem aplicar um filtro use um Where(<expressão de busca>)

        // private readonly IRepository<Categoria> _repository; // utilizando o repositorio generico
        private readonly IUnitOfWork? _unitOfWork;
        private readonly IConfiguration _configuration;
        private readonly ILogger<CategoriasController> _logger;
        // private readonly IMeuServico _meuServico; // a forma mais usual de fazer isso seria assim ao invés do metodo GetSaudacaoFromServices

        // Injetando a instancia de contexto no controlador
        //public CategoriasController(AppDbContext context, IMeuServico meuServico)
        //{
        //    _context = context;
        //    _configuration = configuration;
        //    // _meuServico = meuServico;
        //}

        public CategoriasController(IUnitOfWork unitOfWork, IConfiguration configuration, ILogger<CategoriasController> logger)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration; // atribuindo o valor da injeção a variavel _configuration
            _logger = logger;
        }

        [HttpGet("LerArquivoConfiguracao")]
        public string GetValores()
        {

            var valor1 = _configuration["chave1"]; // obter os valores que estão no appsettings.json
            var valor2 = _configuration["chave2"];

            var secao1 = _configuration["secao1:chave2"]; // obtem o valor que está na seção1

            return $"Chave1 = {valor1}\nChave2 = {valor2}\nSeção1 -> Chave2 = {secao1}";

        }

        // metodo que vai utilizar o serviço que vai ser obtido via injeção de dependencias
        [HttpGet("UsandoFromServices/{nome:alpha}")]
        public ActionResult<string> GetSaudacaoFromServices([FromServices] IMeuServico meuServico, string nome)
        {
            return meuServico.Saudacao(nome);
        }

        [HttpGet("SemUsarFromServices/{nome:alpha}")]
        public ActionResult<string> GetSaudacaoSemFromServices(IMeuServico meuServico, string nome)
        {
            return meuServico.Saudacao(nome);
        }

        [HttpGet("pagination")]
        public async Task<ActionResult<IEnumerable<CategoriaDTO>>> Get([FromQuery] CategoriasParameters categoriasParameters)
        {

            var categorias = await _unitOfWork.CategoriaRepository.GetCategoriasAsync(categoriasParameters);

            return ObterCategorias(categorias);

        }

        [HttpGet("filter/nome/pagination")]
        public async Task<ActionResult<IEnumerable<CategoriaDTO>>> Get([FromQuery] CategoriasFiltroNome categoriasFiltroNomeParams)
        {

            var categorias = await _unitOfWork.CategoriaRepository.GetCategoriasFiltroNomeAsync(categoriasFiltroNomeParams);

            return ObterCategorias(categorias);

        }

        private ActionResult<IEnumerable<CategoriaDTO>> ObterCategorias(IPagedList<Categoria> categorias)
        {
            // Utilizando a Paginação sincrona (PagedList):

            // var metaData = new
            // {
            //    categorias.TotalCount,
            //    categorias.PageSize,
            //    categorias.CurrentPage,
            //    categorias.TotalPages,
            //    categorias.HasNext,
            //    categorias.HasPrevious
            // };

            // Paginação Assíncrona:

            var metaData = new
            {
                categorias.Count,
                categorias.PageSize,
                categorias.PageCount,
                categorias.TotalItemCount,
                categorias.HasNextPage,
                categorias.HasPreviousPage
            };

            Response.Headers.Append("X-Pagination", JsonConvert.SerializeObject(metaData));

            var categoriasDTO = categorias.ToCategoriaDTOList();

            return Ok(categoriasDTO);
        }

        [HttpGet] // No metodo action podemos retornar todos os metodos da classe ActionResult ou o tipo que ele quer retornar que no caso é o IEnumerable<Produto>
        [DisableRateLimiting] // desabilitando o limite de taxa desse endpoint
        public async Task<ActionResult<IEnumerable<CategoriaDTO>>> Get() // Usamos o IEnumerable porque aqui temos uma interface só de leitura e ele permite adiar a execução (ou seja ele trabalha por demanda) e não precisamos ter toda a coleção em memoria e ele é mais otimizado
        {

            try
            {
                // throw new DataMisalignedException(); // simular erro
                var categorias = await _unitOfWork.CategoriaRepository.GetAllAsync();

                // Mapeamento Manual:
                // var categoriasDTO = new List<CategoriaDTO>();
                //foreach (var categoria in categoriasDTO)
                //{

                //    var categoriaDTO = new CategoriaDTO()
                //    {
                //        CategoriaId = categoria.CategoriaId,
                //        Nome = categoria.Nome,
                //        ImagemUrl = categoria.ImagemUrl,
                //    };

                //    categoriasDTO.Add(categoriaDTO);
                //}

                // Mapeamento com metodos de extensão
                var categoriasDTO = categorias.ToCategoriaDTOList();

                return Ok(categoriasDTO);
                // return _context.Categorias.Include(p => p.Produtos).AsNoTracking().ToList(); // O metodo include permite carregar entidades relacionadas, o metodo AsNoTracking melhora o desempenho e devemos usa-lo quando temos certeza que o retorno dessa consulta os objetos não vão precisar ser alterados isso vale para as consultas Get // não se deve apenas colocar o include porque faz perder desempenho porque dependendo do tamanho da entidade vai sobrecarregar a aplicação

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um problema ao tratar a sua solicitação"); // informa o codigo do erro o tipo de erro e a mensagem que colocamos aqui

            }

        }

        [DisableCors] // desabilitando a politica definida lá em cima nesse metodo action
        [HttpGet("{id:int}", Name = "ObterCategoria")] // recepção do id que esta vindo no request e o :<restrição é o tipo que tem que ser>, o Name = '<NOME_DA_ROTA>' é uma rota nomeada
        public async Task<ActionResult<CategoriaDTO>> Get(int id)
        {

            try
            {

                var categoria = await _unitOfWork.CategoriaRepository.GetAsync(c => c.CategoriaId == id);
                if (categoria is null)
                {
                    _logger.LogWarning($"A categoria com o id '{id}' não foi localizada");
                    return NotFound($"A categoria com o id '{id}' não foi localizada");
                }

                // Mapeamento manual - Está sujeito a erros e deixa o codigo mais extenso
                // var categoriaDTO = new CategoriaDTO() 
                // {
                //    CategoriaId = categoria.CategoriaId,
                //    Nome = categoria.Nome,
                //    ImagemUrl = categoria.ImagemUrl,
                // };

                var categoriaDTO = categoria.ToCategoriaDTO();

                return Ok(categoriaDTO);

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um problema ao tratar a sua solicitação");

            }

        }

        [HttpPost]
        public async Task<ActionResult<CategoriaDTO>> Post(CategoriaDTO categoriaDTO)
        {

            if (categoriaDTO is null)
            {
                _logger.LogWarning("Dados Inválidos");
                return BadRequest("Dados Inválidos");
            }

            var categoria = categoriaDTO.ToCategoria();

            var categoriaCriada = _unitOfWork.CategoriaRepository.Create(categoria); // o metodo create aqui só aceita objetos Categoria e como está passando no EndPoint um objeto CategoriaDTO devemos fazer a conversão para que o metodo Create aceite
            await _unitOfWork.CommitAsync(); // Garantindo a atomicidade da transação

            var novaCategoriaDTO = categoriaCriada.ToCategoriaDTO();

            // Explicação: O metodo post recebe o produto, inclui no contexto, persiste ele no banco de dados, retorna 201, aciona a rota 'ObterProduto' e com o id do produto e vai retornar o produto
            return new CreatedAtRouteResult("ObterCategoria", new { id = novaCategoriaDTO.CategoriaId }, novaCategoriaDTO); // retorna o 201 no header location, o '"ObterProduto"' é o nome da rota para poder obter esse produto e o 'new { id = produto.ProdutoId }' é para informar qual o ID que acabou de ser incluido e informamos o objeto 'Produto' que foi incluido

        }

        [Authorize]
        [HttpPut("{id:int}")]
        public async Task<ActionResult<CategoriaDTO>> Put(int id, CategoriaDTO categoriaDTO)
        {

            if (id != categoriaDTO.CategoriaId)
            {
                _logger.LogWarning("Dados Inválidos");
                return BadRequest();
            }

            var categoria = categoriaDTO.ToCategoria();

            var categoriaAtualizada = _unitOfWork.CategoriaRepository.Update(categoria);
            await _unitOfWork.CommitAsync();

            var novaCategoriaAtualizadaDTO = categoriaAtualizada.ToCategoriaDTO();

            return Ok(novaCategoriaAtualizadaDTO);

        }


        [HttpDelete("{id:int}")]
        [Authorize(Policy = "AdminOnly")] // Apenas quem tiver esse perfil 'AdminOnly' poderá usar esse endpoint
        public async Task<ActionResult<CategoriaDTO>> Delete(int id)
        {

            var categoria = await _unitOfWork.CategoriaRepository.GetAsync(c => c.CategoriaId == id);
            // var produto = _context.Produtos?.Find(id); // Esse metodo Find() ele primeiro vai tentar localizar o produto na memoria, só que pra isso funcionar o ID deve ser a chave primaria definida na tabela

            if (categoria is null)
            {
                _logger.LogWarning($"A categoria com o id '{id}' não foi localizada");
                return NotFound($"A categoria com o id '{id}' não foi localizada");
            }

            var categoriaExcluida = _unitOfWork.CategoriaRepository.Delete(categoria);
            await _unitOfWork.CommitAsync();

            var novaCategoriaExcluidaDTO = categoriaExcluida.ToCategoriaDTO();

            return Ok("Categoria Removido: " + novaCategoriaExcluidaDTO);

        }

    }

}
