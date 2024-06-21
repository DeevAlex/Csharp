using APICatalogo.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace APICatalogo.Repositories;

public class Repository<T> : IRepository<T> where T : class // Restrição para o tipo T seja uma classe ou um tipo de referencia, Ex.: Produto, Categoria ou outras. 
{

    protected readonly AppDbContext? _context; // o protected significa que essa variavel seja acessada pelas classes derivadas

    // Podemos fazer a injeção de dependencias aqui porque definimos que a mesma operação pode ser realizada na classe Program.cs
    public Repository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        // AsNoTracking ganha memoria e mais desempenho, pois ele informa ao EF Core que pare de gerenciar os estados das entidades na memoria, com o AsNoTracking não podemos fazer alterações em algum dos objetos retornados nessa lista logo após retornar-los, porque o EF Core não vai saber se algum objeto foi alterado/modifcado porque desabilitamos o rastreamento das entidades, então como nesse caso estamos apenas retornando uma lista de objetos apenas para exibir e depois vamos selecionar um objeto e ai novamente vamos inclui-los no contexto dai podemos utilizar o AsNoTracking
        return await _context.Set<T>().AsNoTracking().ToListAsync(); // o metodo Set do EF Core serve para acessar uma coleção ou uma tabela, como no nosso caso aqui será uma coleçao do Tipo T, quando chamamos o Set()<T> estamos obtendo o conjunto da tabela correspondente no banco de dados ao Tipo T, se T for produto vai ser a tabela produtos.
    }

    public async Task<T?> GetAsync(Expression<Func<T, bool>> predicate)
    {
        return await _context.Set<T>().FirstOrDefaultAsync(predicate); // vai retornar um objeto que atende o predicado ou vai retonar null caso não encontre
    }

    public T Create(T entity)
    {
        _context.Set<T>().Add(entity);
        // _context.SaveChanges();
        return entity;
    }

    public T Update(T entity)
    {
        _context.Set<T>().Update(entity); // Aqui estamos marcando todas as propriedades da entidade como modificada quando usamos o SaveChanges() o EF Core vai gerar uma instrução SQL que vai atualizar todas as colunas da entidade na base de dados, mais indicado para atualizações mais completas e é mais simples.
        // _context.Entry(entity).State = EntityState.Modified; // Aqui estamos definindo explicitamente o estado da entidade como modificada, então o EF Core vai detectar que a entidade foi alterada e vai gerar uma instrução SQL via atualização para essa entidade aqui temos um controle mais refinado sobre o estado da entidade e podemos definir o estado de entidades individuais como estamos fazendo aqui
        // _context.SaveChanges();
        return entity;
    }

    public T Delete(T entity)
    {
        _context.Set<T>().Remove(entity); // marcando a entidade como excluida
        // _context.SaveChanges(); // efetivando a exclusão no banco de dados
        return entity;
    }

}
