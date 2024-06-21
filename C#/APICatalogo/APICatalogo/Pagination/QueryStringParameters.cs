namespace APICatalogo.Pagination;

// Lembrando: Classe abstrata não pode ser instanciada diretamente, utilizada como classe base para outras classes, pode conter metodos abstratos, concretos, propriedades, campos, eventos e ela ajuda a promover a reutilização do codigo 
public abstract class QueryStringParameters
{

    const int maxPageSize = 50; // tamanho maximo da pagina
    public int PageNumber { get; set; } = 1; // numero da pagina, caso não seja passada, o inicial será 1
    private int _pageSize = maxPageSize; // vai controlar 

    public int PageSize
    {
        get
        {
            return _pageSize;
        }

        set
        {
            _pageSize = (value > maxPageSize) ? maxPageSize : value; // se quando for atribuir o valor da pagina o valor for maior que maxPageSize defina maxPageSize ou o valor passado
        }

    }

}
