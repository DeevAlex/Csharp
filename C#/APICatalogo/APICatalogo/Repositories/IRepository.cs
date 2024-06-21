using System.Linq.Expressions;

namespace APICatalogo.Repositories;

public interface IRepository<T>
{

    // Cuidado para não violar o principio SOLID ISP (Interface Segregation Principle) - Os clientes (da interface) não devem ser forçados a depender de interfaces que não utilizam 

    // Estamos colocando para ser assíncrono, porque esses metodos irão acessar a banco de dados
    Task<IEnumerable<T>> GetAllAsync(); // poderiamos utilizar o IQueryable, 
    Task<T>? GetAsync(Expression<Func<T, bool>> predicate); // O expression faz o compilador vai poder analisar e manipular a expressão lambda, Func<T, bool> é um delegate representa uma função lambda que vai receber um objeto T e vai retornar um bool com base no predicado (criterio usado para filtrar por exemplo)

    // Não estamos colocando para ser assíncrono, porque esses metodos usam o contexto do EF Core na memoria (esta sendo feita pela unit of work) e a unica operação que acessaria os dados seria a invocação do metodo SaveChanges()
    T Create(T entity);
    T Update(T entity);
    T Delete(T entity);

}
