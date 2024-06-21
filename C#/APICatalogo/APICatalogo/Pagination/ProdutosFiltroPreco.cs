namespace APICatalogo.Pagination;

// Para termos acesso aos atributos PageNumber e PageSize devemos herdar de 'QueryStringParameters'
public class ProdutosFiltroPreco : QueryStringParameters
{

    public decimal? Preco { get; set; }
    public string? PrecoCriterio { get; set; } // "maior", "menor" ou "igual"

}
