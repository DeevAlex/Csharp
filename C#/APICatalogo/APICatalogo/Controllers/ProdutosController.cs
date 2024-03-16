using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Controllers
{
    [Route("[controller]")] // Rota se tiver, [Route("[controller]")] ele usara apenas o nome do controlador Ex.: http://localhost:<porta>/<nome_do_controller>/ . se estiver assim: [Route("Produtos/{Action}")] a rota será http://localhost:<porta>/<Pode_ser_qualquer_nome>/<Nome_do_Metodo>
    [ApiController]
    public class ProdutosController : ControllerBase
    {

        private readonly AppDbContext _context;

        // Injetando a instancia de contexto no controlador
        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet] // No metodo action podemos retornar todos os metodos da classe ActionResult ou o tipo que ele quer retornar que no caso é o IEnumerable<Produto>
        public ActionResult<IEnumerable<Produto>> Get() // Usamos o IEnumerable porque aqui temos uma interface só de leitura e ele permite adiar a execução (ou seja ele trabalha por demanda) e não precisamos ter toda a coleção em memoria e ele é mais otimizado
        {
            // através do contexto (_context) podemos acessar a tabela Produtos, ele sabe que tem que porque definimos no contexto (nessa linha: public DbSet<Produto>? Produtos { get; set; })
            var produtos = _context.Produtos?.ToList();

            if (produtos is null)
            {
                return NotFound("Produtos não encontrados"); // NotFount é igual 404
            }

            return produtos;
        }

        [HttpGet("{id:int}", Name = "ObterProduto")] // recepção do id que esta vindo no request e o :<restrição é o tipo que tem que ser>, o Name = '<NOME_DA_ROTA>' é uma rota nomeada
        public ActionResult<Produto> Get(int id)
        {

            var produto = _context.Produtos?.FirstOrDefault(criterio => criterio.ProdutoId == id ); // acessando a tabela e pegando o primeiro elemento, caso seja esse metodo 'FirstOrDefault' ele pega ou o primeiro ou o valor default, se estiver apenas First() ele apenas pega o primeiro
            if (produto is null)
            {
                return NotFound("Produto não encontrado");
            }

            return produto;

        }

        [HttpPost]
        public ActionResult Post(Produto produto)
        {

            if (produto is null)
            {
                return BadRequest();
            }

            _context.Produtos?.Add(produto); // o Add vai adicionar no contexto até o momento aqui estamos trabalhando na memoria
            _context.SaveChanges(); // Ele persiste os dados na tabela

            // Explicação: O metodo post recebe o produto, inclui no contexto, persiste ele no banco de dados, retorna 201, aciona a rota 'ObterProduto' e com o id do produto e vai retornar o produto
            return new CreatedAtRouteResult("ObterProduto", new { id = produto.ProdutoId }, produto); // retorna o 201 no header location, o '"ObterProduto"' é o nome da rota para poder obter esse produto e o 'new { id = produto.ProdutoId }' é para informar qual o ID que acabou de ser incluido e informamos o objeto 'Produto' que foi incluido

        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Produto produto)
        {

            if (id != produto.ProdutoId)
            {
                return BadRequest();
            }

            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(produto);

        }


        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {

            var produto = _context.Produtos?.FirstOrDefault(p => p.ProdutoId == id);
            // var produto = _context.Produtos?.Find(id); // Esse metodo Find() ele primeiro vai tentar localizar o produto na memoria, só que pra isso funcionar o ID deve ser a chave primaria definida na tabela

            if (produto is null)
            {
                return NotFound("Produto não localizado");
            }

            _context.Produtos?.Remove(produto); // removendo produto do contexto
            _context.SaveChanges();

            return Ok("Produto Removido: " + produto);

        }


    }
}
