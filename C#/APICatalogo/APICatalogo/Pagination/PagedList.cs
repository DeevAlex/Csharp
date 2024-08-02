using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace APICatalogo.Pagination;

public class PagedList<T> : List<T> where T : class
{

    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
    public int PageSize { get; set; }
    public int TotalCount { get; set; }
    public bool HasPrevious => CurrentPage > 1;
    public bool HasNext => CurrentPage < TotalPages;

    public PagedList(List<T> items, int count, int pageNumber, int pageSize)
    {
        CurrentPage = pageNumber;
        TotalPages = (int) Math.Ceiling(count / (double) pageSize); // calculando o total de paginas dividindo o total de itens pelo tamanho da pagina
        PageSize = pageSize;
        TotalCount = count;

        AddRange(items);

    }

    public static PagedList<T> ToPagedList(IQueryable<T> source, int pageNumber, int pageSize)
    {

        // pulando as paginas anteriores (calculo para saber quantos itens devem ser pulados na coleçao de dados antes de começar a retornar os itens em Take()), e pegando os resultados (Take() onde vai obter a qtd de produtos a ser retornado) e tranformando em uma lista

        var count = source.Count();
        var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

        return new PagedList<T>(items, count, pageNumber, pageSize);

    }

}
