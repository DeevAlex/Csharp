using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using APICatalogo.Repositories;
using System.Runtime.Intrinsics.X86;
using APICatalogo.DTOs;
using AutoMapper;
using System;
using Microsoft.AspNetCore.JsonPatch;
using APICatalogo.Pagination;
using Newtonsoft.Json;
using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;
using X.PagedList;
using Microsoft.AspNetCore.Authorization;

namespace APICatalogo.Controllers
{

    [Route("[controller]")] // Rota se tiver, [Route("[controller]")] ele usara apenas o nome do controlador Ex.: http://localhost:<porta>/<nome_do_controller>/ . se estiver assim: [Route("Produtos/{Action}")] a rota será http://localhost:<porta>/<Pode_ser_qualquer_nome>/<Nome_do_Metodo>
    [ApiController]
    public class ProdutosController : ControllerBase
    {

        // Tipos de retorno:
        // Podemos retornar um tipo especifico (string, Produto, int, etc), IActionResult (é apropriado quando varios tipos de retorno ActionResult são possiveis em metodo Action) e ActionResult<T> (Permite o retorno de um tipo derivado de ActionResult ou o retorno de um tipo espefico (T).)

        // Antes da Unit Of Work
        // IRepository<Produto> _repository; // não precisaria dessa instancia pois já está implementando o repositorio generico na interface 'IProdutoRepository'
        // IProdutoRepository _produtoRepos itory; // quando temos um metodo especifico na abordagem hibrida devemos ter a instancia dos dois repositorios

        // Depois da Unit Of Work
        private readonly IUnitOfWork? _unitOfWork;
        private readonly IMapper _mapper; // o mapeamento do AutoMapper pode perder um pouco mais o desempenho, então tem que visar o que vai compensar

        private readonly IConfiguration _configuration;
        private readonly ILogger<ProdutosController> _logger;

        // Injetando a instancia de contexto no controlador
        public ProdutosController(IUnitOfWork unitOfWork, IConfiguration config, ILogger<ProdutosController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _configuration = config;
            _mapper = mapper;
        }

        [HttpGet("produtos/{id:int}")]
        public async Task<ActionResult<IEnumerable<ProdutoDTO>>> GetProdutosCategoria(int id)
        {
            var produtos = await _unitOfWork.ProdutoRepository.GetProdutoPorCategoriaAsync(id); // utilizando o unico metodo do repositorio hibrido

            if (produtos is null || !produtos.Any())
                return NotFound();

            var produtosDTO = _mapper.Map<IEnumerable<ProdutoDTO>>(produtos); // var destino = _mapper.Map<(Destino)>(origem);, está convertendo os produtos da variavel produtos para um IEnumerable de produtosDTO

            return Ok(produtosDTO);
        }

        [HttpGet] // No metodo action podemos retornar todos os metodos da classe ActionResult ou o tipo que ele quer retornar que no caso é o IEnumerable<Produto>
        public async Task<ActionResult<IEnumerable<ProdutoDTO>>> Get() // Usamos o IEnumerable porque aqui temos uma interface só de leitura e ele permite adiar a execução (ou seja ele trabalha por demanda) e não precisamos ter toda a coleção em memoria e ele é mais otimizado
        {
            // através do contexto (_context) podemos acessar a tabela Produtos, ele sabe que tem que porque definimos no contexto (nessa linha: public DbSet<Produto>? Produtos { get; set; })
            var produtos = await _unitOfWork.ProdutoRepository.GetAllAsync();

            if (produtos is null)
            {
                _logger.LogWarning("Produtos não encontrados");
                return NotFound("Produtos não encontrados"); // NotFount é igual 404
            }

            var produtosDTO = _mapper.Map<IEnumerable<ProdutoDTO>>(produtos);

            return Ok(produtosDTO);
        }

        [HttpGet("primeiro")] // caso tenhamos mais de http request e que dá o erro 'Ambiguous match found.' é só colocar assim: [HttpGet("<nome da rota>")]. na rota ficaria assim: <Nome da Rota>/primeiro, Ex.: Produtos/primeiro, caso estiver com uma barra no começo assim: [httpGet("/primeiro")] a rota será http://<localhost>:<porta>/primeiro
        public async Task<ActionResult<ProdutoDTO>> GetPrimeiro()
        {

            var produto = await _unitOfWork.ProdutoRepository.GetAsync(p => p.ProdutoId == 1);

            if (produto is null)
            {
                _logger.LogWarning("Produtos não encontrados");
                return NotFound("Produtos não encontrados");
            }

            var produtoDTO = _mapper.Map<ProdutoDTO>(produto);

            return Ok(produtoDTO);
        }

        [HttpGet("{id:int:min(1)}", Name = "ObterProduto")] // recepção do id que esta vindo no request e o :<restrição é o tipo que tem que ser>, o Name = '<NOME_DA_ROTA>' é uma rota nomeada, podemos atribuir um valor padrão no parametro da url assim [HttpGet("{id}/{nome=<valor padrão>}", Name = "ObterProduto")], o min(<numero>) define uma restrição de rota e apenas valores igual ou superior ao numero informado no min() caso seja menor que o valor no metodo min() é retornado um 404 devolvido pelo mecanismo de roteamento do ASP .NET Core, fazendo com que o metodo não receba o metodo Action e dessa forma uma consulta desnecessaria ao BD foi evitada e o :alpha é para aceitar apenas valores de parametros que sejam alpha numericos de A-Z ou a-z podemos colocar uma restrição de comprimento :length(<tamanho>) o metodo action só vai ser acionado caso tenha o tamanho definido nem mais nem menos apenas IGUAIS (não devemos usar esse recurso para validar a entrada do usuario na URL só usamos para distinguir entre duas rotas parecidas), Ex.: public ActionResult<ProdutoDTO> Get([FromQuery] int id) {}
        public async Task<ActionResult<ProdutoDTO>> Get(int id) // public async Task<ActionResult<Produto>> Get(int id, [BindRequired] string nome), [BindRequired] faz com que esse metodo Action exija esse parâmetro nome, [FromBody] para dados no corpo da requisição, [FromRoute] para dados na rota da URL. [FromForm] para dados em um formulário enviado. [FromHeader] para dados nos cabeçalhos da requisição. e o [FromQuery] indica que o parâmetro id deve ser obtido da query string.
        {

            var produto = await _unitOfWork.ProdutoRepository.GetAsync(p => p.ProdutoId == id);

            if (produto is null)
            {
                _logger.LogWarning("Produto não encontrado");
                return NotFound("Produto não encontrado");
            }

            var produtoDTO = _mapper.Map<ProdutoDTO>(produto);

            return Ok(produtoDTO);

        }

        [HttpGet("pagination")]
        public async Task<ActionResult<IEnumerable<ProdutoDTO>>> Get([FromQuery] ProdutosParameters produtosParameters) // como fica na URL: /Produtos/pagination?PageNumber=1&PageSize=5
        {

            var produtos = await _unitOfWork.ProdutoRepository.GetProdutosAsync(produtosParameters);

            return ObterProdutos(produtos);

        }

        [HttpGet("filter/preco/pagination")]
        public async Task<ActionResult<IEnumerable<ProdutoDTO>>> Get([FromQuery] ProdutosFiltroPreco produtosFiltroPrecoParams)
        {

            var produtos = await _unitOfWork.ProdutoRepository.GetProdutosFiltroPrecoAsync(produtosFiltroPrecoParams);

            return ObterProdutos(produtos);

        }

        private ActionResult<IEnumerable<ProdutoDTO>> ObterProdutos(IPagedList<Produto> produtos)
        {
            // variavel anonima, onde vamos obter as informações retornadas pela varivael produtos
            //var metaData = new
            //{
            //    produtos.TotalCount,
            //    produtos.PageSize,
            //    produtos.CurrentPage,
            //    produtos.TotalPages,
            //    produtos.HasNext,
            //    produtos.HasPrevious
            //};

            var metaData = new
            {
                produtos.Count,
                produtos.PageSize,
                produtos.PageCount,
                produtos.TotalItemCount,
                produtos.HasNextPage,
                produtos.HasPreviousPage
            };

            // incluindo os meta dados no response usando o Append(), "X-Pagination" está defindo um nome para esse header e fazendo a serialização dos meta dados, essa serialização está sendo feita com o NewtonSoft.Json, Poderia fazer ela com o pacote do System porém vai exigir mais codigo então do jeito que está é mais simples
            Response.Headers.Append("X-Pagination", JsonConvert.SerializeObject(metaData));

            // retornando para um IEnumerable<ProdutoDTO>
            var produtosDTO = _mapper.Map<IEnumerable<ProdutoDTO>>(produtos);

            return Ok(produtosDTO);

        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<ProdutoDTO>> Post(ProdutoDTO produtoDTO)
        {

            if (produtoDTO is null)
            {
                _logger.LogWarning("Produto está vazio");
                return BadRequest();
            }

            var produto = _mapper.Map<Produto>(produtoDTO);

            var produtoCriado = _unitOfWork.ProdutoRepository.Create(produto); // o Add vai adicionar no contexto até o momento aqui estamos trabalhando na memoria
            await _unitOfWork.CommitAsync();

            var novoProdutoDTO = _mapper.Map<ProdutoDTO>(produtoCriado);

            // Explicação: O metodo post recebe o produto, inclui no contexto, persiste ele no banco de dados, retorna 201, aciona a rota 'ObterProduto' e com o id do produto e vai retornar o produto
            return new CreatedAtRouteResult("ObterProduto", new { id = novoProdutoDTO.ProdutoId }, novoProdutoDTO); // retorna o 201 no header location, o '"ObterProduto"' é o nome da rota para poder obter esse produto e o 'new { id = produto.ProdutoId }' é para informar qual o ID que acabou de ser incluido e informamos o objeto 'Produto' que foi incluido

        }

        [HttpPatch("{id}/UpdatePartial")]
        public async Task<ActionResult<ProdutoDTOUpdateResponse>> Patch(int id, JsonPatchDocument<ProdutoDTOUpdateRequest> patchProdutoDTO) // O JsonPatchDocument<ProdutoDTOUpdateRequest> é um parâmetro que representa um documento de patch JSON usado para atualizar parcialmente um recurso
        {

            if (patchProdutoDTO is null || id <= 0)
            {
                _logger.LogWarning("O patchProdutoDTO ou é nulo ou é menor ou igual a 0");
                return BadRequest();
            }

            var produto = await _unitOfWork.ProdutoRepository.GetAsync(p => p.ProdutoId == id);

            if (produto == null)
            {
                _logger.LogWarning("O produto não foi encontrado");
                return NotFound();
            }

            var produtoUpdateRequest = _mapper.Map<ProdutoDTOUpdateRequest>(produto);

            // Aplicando as alterações parciais do objeto 'patchProdutoDTO' ao produto 'produtoUpdateRequest', o 'ModelState' vai relatar qualquer erro ou problema de validação seja registrado no ModelState
            patchProdutoDTO.ApplyTo(produtoUpdateRequest, ModelState);

            // verificando o 'ModelState' se ele contém erros de validação após a aplicação das alterações que foram feitas no metodo 'ApplyTo'

            if (TryValidateModel(produtoUpdateRequest) || !ModelState.IsValid)
            {
                _logger.LogWarning("Erros de validação: " + ModelState);
                return BadRequest(ModelState);
            }

            _mapper.Map(produtoUpdateRequest, produto); // mapeando o objeto 'produtoUpdateRequest' devolta para o objeto 'Produto' atualizando com as atualizações parciais

            // atualizando os dados na tabela
            _unitOfWork.ProdutoRepository.Update(produto);
            await _unitOfWork.CommitAsync();

            // retornando o 'ProdutoDTOUpdateResponse' e fazendo o mapeamento
            return Ok(_mapper.Map<ProdutoDTOUpdateResponse>(produto));

        }


        [HttpPut("{id:int}")]
        public async Task<ActionResult<ProdutoDTO>> Put(int id, ProdutoDTO produtoDTO) // Put é usado para atualizar um recurso inteiramente, ele envia recurso completo com todas as informações e ele é idempotente. Uma alternativa para o PUT e o PATCH ele realiza uma atualização parcial, ele envia apenas as alterações que desejamos aplicar e nem sempre é idempotente
        {

            if (id != produtoDTO.ProdutoId)
            {
                _logger.LogWarning("Produto não encontrado");
                return BadRequest();
            }

            var produto = _mapper.Map<Produto>(produtoDTO);

            var produtoAtualizado = _unitOfWork.ProdutoRepository.Update(produto);
            await _unitOfWork.CommitAsync();

            var produtoAtualizadoDTO = _mapper.Map<ProdutoDTO>(produtoAtualizado);

            return Ok(produtoAtualizadoDTO);

        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ProdutoDTO>> Delete(int id)
        {

            var produto = await _unitOfWork.ProdutoRepository.GetAsync(p => p.ProdutoId == id);

            if (produto is null)
                return NotFound("Produto não encontrado...");

            var produtoExcluido = _unitOfWork.ProdutoRepository.Delete(produto);
            await _unitOfWork.CommitAsync();

            var produtoExcluidoDTO = _mapper.Map<ProdutoDTO>(produtoExcluido);

            return Ok(produtoExcluidoDTO);

        }

    }

    // Lembretes Para Retornos Assíncronos nas APIs:

    // Void:

    // Pode ser usado em manipuladores de eventos assincronos que requerem um tipo de retorno
    // void.
    // Para métodos assíncronos que não retornam um valor, devemos usar Task em vez de void,
    // pois os métodos assíncronos que retornam void não permitem que você aguarde a
    // conclusão da operação

    // Task:

    // Usado quando os métodos assíncronos não contêm uma instrução de retorno ou contém uma
    // instrução de retorno que não retorna um operando ou tipo espetífico
    // Um método assincrono que retorna Task permite que você aguarde a conclusão da
    // operação assincrona usando await, e, isso é útil quando você deseja esperar que a operaç
    // seja concluída antes de continuar com o restante do código.

    // Task<T>:

    // É usado quando métodos assincronos contêm uma instrução de retorno que retorna um
    // valor específico do tipo T(int, string, double, tipos definidos pelo usuário, etc.)
    // O uso do tipo de retorno Task<T> permite que o chamador aguarde a resposta do método
    // assíncrono para que a conclusão do chamador possa ser suspensa até que o método
    // assíncrono tenha terminado

    // ValueTask e ValueTask<T>:

    // São uma struct e foram introduzidos para impedir a alocação de um objeto Task,
    // caso o resultado da operação assincrona já esteja disponível no momento da espera.
    // - Ele melhora o desempenho porque não precisa de alocação de heap;
    // - É fácil e flexível de implementar;

    // IAsyncEnumerable<T>:

    // É uma interface introduzida no C# 8.0 que permite a iteração assincrona sobre uma
    // sequência de valores sendo usada para lidar com coleções ou fluxos de dados que podem
    // ser produzidos ou recuperados de forma assíncr

}
