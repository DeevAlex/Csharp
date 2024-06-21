using APICatalogo.Context;
using APICatalogo.Models;
using APICatalogo.Pagination;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace APICatalogo.Repositories;

public class ProdutoRepository : Repository<Produto>, IProdutoRepository
{

    public ProdutoRepository(AppDbContext context) : base(context)
    {
    }

    // devemos implementar o metodo especifico definido no repositorio 'IProdutoRepository'
    public async Task<IEnumerable<Produto>> GetProdutoPorCategoriaAsync(int id)
    {
        var produtos = await GetAllAsync();
        var produtosCategoria = produtos.Where(c => c.CategoriaId == id); // pegar todos onde o produtoId for igual ao id que for passado como parametro
        return produtosCategoria;
    }

    // Sem utilizar a classe 'PagedList'
    //public IEnumerable<Produto> GetProdutos(ProdutosParameters produtosParameters)
    //{
    //    // Pegando todos os produtos, ordenando pelo nome, e pulando as paginas anteriores (calculo para saber quantos itens devem ser pulados na coleçao de dados antes de começar a retornar os itens em Take()), e pegando os resultados (Take() onde vai obter a qtd de produtos a ser retornado) e tranformando em uma lista de 'Produtos'
    //    return GetAll().OrderBy(p => p.Nome).Skip((produtosParameters.PageNumber - 1) * produtosParameters.PageSize).Take(produtosParameters.PageSize).ToList();
    //}

    public async Task<IPagedList<Produto>> GetProdutosAsync(ProdutosParameters produtosParameters)
    {

        var produtos = await GetAllAsync();

        var produtosOrdenados = produtos.OrderBy(p => p.ProdutoId).AsQueryable();

        // var resultado = PagedList<Produto>.ToPagedList(produtosOrdenados, produtosParameters.PageNumber, produtosParameters.PageSize); // criando uma instancia de 'PagedList' de Produtos fazendo a ordenação

        var resultado = await produtosOrdenados.ToPagedListAsync(produtosParameters.PageNumber, produtosParameters.PageSize);

        return resultado;

    }

    public async Task<IPagedList<Produto>> GetProdutosFiltroPrecoAsync(ProdutosFiltroPreco produtoFiltroPrecoParams)
    {

        var produtos = await GetAllAsync();

        // Criterios para a filtragem
        if (produtoFiltroPrecoParams.Preco.HasValue && !string.IsNullOrEmpty(produtoFiltroPrecoParams.PrecoCriterio))
        {

            if (produtoFiltroPrecoParams.PrecoCriterio.Equals("maior", StringComparison.OrdinalIgnoreCase)) // StringComparison.OrdinalIgnoreCase ignora se é maiuscula ou minuscula
            {
                produtos = produtos.Where(p => p.Preco > produtoFiltroPrecoParams.Preco.Value).OrderBy(p => p.Preco);
            } else if (produtoFiltroPrecoParams.PrecoCriterio.Equals("menor", StringComparison.OrdinalIgnoreCase))
            {
                produtos = produtos.Where(p => p.Preco < produtoFiltroPrecoParams.Preco.Value).OrderBy(p => p.Preco);
            } else if (produtoFiltroPrecoParams.PrecoCriterio.Equals("igual", StringComparison.OrdinalIgnoreCase))
            {
                produtos = produtos.Where(p => p.Preco == produtoFiltroPrecoParams.Preco.Value).OrderBy(p => p.Preco);
            }

        }

        // Definindo a paginação sincrona 
        //  var produtosFiltrados = PagedList<Produto>.ToPagedList(produtos.AsQueryable(), produtoFiltroPrecoParams.PageNumber, produtoFiltroPrecoParams.PageSize); // fazendo a paginação com os produtos filtrados

        var produtosFiltrados = await produtos.ToPagedListAsync(produtoFiltroPrecoParams.PageNumber, produtoFiltroPrecoParams.PageSize);

        return produtosFiltrados;

    }
}
