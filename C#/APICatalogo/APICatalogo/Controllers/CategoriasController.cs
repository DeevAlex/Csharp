using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {

        private readonly AppDbContext _context;

        // Injetando a instancia de contexto no controlador
        public CategoriasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet] // No metodo action podemos retornar todos os metodos da classe ActionResult ou o tipo que ele quer retornar que no caso é o IEnumerable<Produto>
        public ActionResult<IEnumerable<Categoria>> Get() // Usamos o IEnumerable porque aqui temos uma interface só de leitura e ele permite adiar a execução (ou seja ele trabalha por demanda) e não precisamos ter toda a coleção em memoria e ele é mais otimizado
        {
            // através do contexto (_context) podemos acessar a tabela Produtos, ele sabe que tem que porque definimos no contexto (nessa linha: public DbSet<Produto>? Produtos { get; set; })
            var categoria = _context.Categorias?.ToList();

            if (categoria is null)
            {
                return NotFound("Categoria não encontrados"); // NotFount é igual 404
            }

            return categoria;
        }

        [HttpGet("{id:int}", Name = "ObterCategoria")] // recepção do id que esta vindo no request e o :<restrição é o tipo que tem que ser>, o Name = '<NOME_DA_ROTA>' é uma rota nomeada
        public ActionResult<Categoria> Get(int id)
        {

            var categoria = _context.Categorias?.FirstOrDefault(criterio => criterio.CategoriaId == id); // acessando a tabela e pegando o primeiro elemento, caso seja esse metodo 'FirstOrDefault' ele pega ou o primeiro ou o valor default, se estiver apenas First() ele apenas pega o primeiro
            if (categoria is null)
            {
                return NotFound("Categoria não encontrada");
            }

            return categoria;

        }

        [HttpPost]
        public ActionResult Post(Categoria categoria)
        {

            if (categoria is null)
            {
                return BadRequest();
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
                return NotFound("Categoria não localizada");
            }

            _context.Categorias?.Remove(categoria); // removendo produto do contexto
            _context.SaveChanges();

            return Ok("Categoria Removido: " + categoria);

        }

    }
}
