using APICatalogo.Context;

namespace APICatalogo.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private IProdutoRepository? _produtoRepo;
    private ICategoriaRepository? _categoriaRepo;

    public AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    // essa abordagem é chamada de 'Lazy Loading (significa adiar a obtenção dos objetos até que eles sejam realmente necessários)'
    public IProdutoRepository ProdutoRepository // permitindo que a classe UnitOfWork, vai fornecer acesso aos repositorios especificos sem termos que ficar criando varias instancias dos repositorios, foi por isso que não foi injetado essas instancias no construtor, se fosse feito isso, toda vez que chamasse-mos a classe 'UnitOfWork' as instancias seriam criadas (isso não está errado, porque no nosso caso sempre vamos precisar dessas instancias, porém, numa aplicação mais complexa talvez nem sempre precisariamos das instancias sendo criadas toda vez que chamasse-mos essa classe 'UnitOfWork', só estamos garantindo que vamos obter as instancias dos repositorios somente se elas não existirem e somente quando precisarmos delas)
    {
        get
        {
            return _produtoRepo = _produtoRepo ?? new ProdutoRepository(_context); // criando uma unica instancia do contexto
        }
    }

    public ICategoriaRepository CategoriaRepository
    {
        get
        {
            return _categoriaRepo = _categoriaRepo ?? new CategoriaRepository(_context); // O ?? (coalescência nula) significa se a variavel/propriedade for nula execute o que estiver depois das interrogações
        }
    }

    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync(); // confirmar as adições/alterações/exclusões na base de dados
    }

    public void Dispose()
    {
        _context?.Dispose(); // libera recursos associados ao contexto do banco de dados
    }
}
