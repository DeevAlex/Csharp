using APICatalogo.Models;
using APICatalogo.Pagination;
using System.Collections.Generic;
using X.PagedList;

namespace APICatalogo.Repositories;

public interface IProdutoRepository : IRepository<Produto>
{

    // Com a abordagem hibrida (herdando os metodos CRUD definidos no repositorio generico e acresentando um metodo especifico):
    Task<IEnumerable<Produto>> GetProdutoPorCategoriaAsync(int id);

    // Antes de mover a logica para 'PagedList'
    // IEnumerable<Produto> GetProdutos(ProdutosParameters produtosParameters); // Obtém os produtos a partir do repositório e aplica a paginação

    // Com 'PagedList'
    Task<IPagedList<Produto>> GetProdutosAsync(ProdutosParameters produtosParameters); // Obtém os produtos a partir do repositório e aplica a paginação
    Task<IPagedList<Produto>> GetProdutosFiltroPrecoAsync(ProdutosFiltroPreco produtoFiltroPreco);

    // Antes da abordagem hibrida:
    //IQueryable<Produto> GetProdutos();
    //Produto GetProduto(int id);
    //Produto Create(Produto produto);
    //bool Update(Produto produto);
    //bool Delete(int id);

}
