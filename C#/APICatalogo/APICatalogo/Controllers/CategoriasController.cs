using APICatalogo.Context;
using APICatalogo.Models;
using APICatalogo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {

        // Toda vez que implementamos Actions que recebem parâmetros estamos usando model binding
        // Para otimizar o desempenho da API use o metodo AsNoTracking, e nunca retorne todos os registros em uma consulta use o metodo Take(<quantidade>), Nunca retorne objetos relacionados sem aplicar um filtro use um Where(<expressão de busca>)

        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;
        // private readonly IMeuServico _meuServico; // a forma mais usual de fazer isso seria assim ao invés do metodo GetSaudacaoFromServices

        // Injetando a instancia de contexto no controlador
        //public CategoriasController(AppDbContext context, IMeuServico meuServico)
        //{
        //    _context = context;
        //    _configuration = configuration;
        //    // _meuServico = meuServico;
        //}

        public CategoriasController(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration; // atribuindo o valor da injeção a variavel _configuration
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

        [HttpGet] // No metodo action podemos retornar todos os metodos da classe ActionResult ou o tipo que ele quer retornar que no caso é o IEnumerable<Produto>
        public ActionResult<IEnumerable<Categoria>> Get() // Usamos o IEnumerable porque aqui temos uma interface só de leitura e ele permite adiar a execução (ou seja ele trabalha por demanda) e não precisamos ter toda a coleção em memoria e ele é mais otimizado
        {

            try
            {
                // throw new DataMisalignedException(); // simular erro
                return _context.Categorias.Include(p => p.Produtos).Where(c => c.CategoriaId <= 5).ToList();
                // return _context.Categorias.Include(p => p.Produtos).AsNoTracking().ToList(); // O metodo include permite carregar entidades relacionadas, o metodo AsNoTracking melhora o desempenho e devemos usa-lo quando temos certeza que o retorno dessa consulta os objetos não vão precisar ser alterados isso vale para as consultas Get // não se deve apenas colocar o include porque faz perder desempenho porque dependendo do tamanho da entidade vai sobrecarregar a aplicação

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um problema ao tratar a sua solicitação"); // informa o codigo do erro o tipo de erro e a mensagem que colocamos aqui

            }

        }

        [HttpGet("{id:int}", Name = "ObterCategoria")] // recepção do id que esta vindo no request e o :<restrição é o tipo que tem que ser>, o Name = '<NOME_DA_ROTA>' é uma rota nomeada
        public ActionResult<Categoria> Get(int id)
        {

            try
            {

                var categoria = _context.Categorias?.FirstOrDefault(criterio => criterio.CategoriaId == id); // acessando a tabela e pegando o primeiro elemento, caso seja esse metodo 'FirstOrDefault' ele pega ou o primeiro ou o valor default, se estiver apenas First() ele apenas pega o primeiro
                if (categoria is null)
                {
                    return NotFound($"A categoria com o id '{id}' não foi localizada");
                }

                return Ok(categoria);

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um problema ao tratar a sua solicitação");

            }

        }

        [HttpPost]
        public ActionResult Post(Categoria categoria)
        {

            if (categoria is null)
            {
                return BadRequest("Dados Inválidos");
            }

            _context.Categorias?.Add(categoria); // o Add vai adicionar no contexto até o momento aqui estamos trabalhando na memoria
            _context.SaveChanges(); // Ele persiste os dados na tabela

            // Explicação: O metodo post recebe o produto, inclui no contexto, persiste ele no banco de dados, retorna 201, aciona a rota 'ObterProduto' e com o id do produto e vai retornar o produto
            return new CreatedAtRouteResult("ObterCategoria", new { id = categoria.CategoriaId }, categoria); // retorna o 201 no header location, o '"ObterProduto"' é o nome da rota para poder obter esse produto e o 'new { id = produto.ProdutoId }' é para informar qual o ID que acabou de ser incluido e informamos o objeto 'Produto' que foi incluido

        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Categoria categoria)
        {

            if (id != categoria.CategoriaId)
            {
                return BadRequest();
            }

            _context.Entry(categoria).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(categoria);

        }


        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {

            var categoria = _context.Categorias?.FirstOrDefault(c => c.CategoriaId == id);
            // var produto = _context.Produtos?.Find(id); // Esse metodo Find() ele primeiro vai tentar localizar o produto na memoria, só que pra isso funcionar o ID deve ser a chave primaria definida na tabela

            if (categoria is null)
            {
                return NotFound($"A categoria com o id '{id}' não foi localizada");
            }

            _context.Categorias?.Remove(categoria); // removendo produto do contexto
            _context.SaveChanges();

            return Ok("Categoria Removido: " + categoria);

        }

    }
}
