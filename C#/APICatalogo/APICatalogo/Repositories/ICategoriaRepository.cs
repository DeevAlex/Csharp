using APICatalogo.Models;
using APICatalogo.Pagination;
using X.PagedList;

namespace APICatalogo.Repositories;

public interface ICategoriaRepository : IRepository<Categoria>
{

    // Repository Especifico:
    // Cria uma interface para uma entidade especifica contendo o contrato que define os métodos que a classe concreta deverá implementar (motivação para trocar para o genérico: o especifico pode gerar complexibilidade do código, repetição de código, manutenção trabalhosa e eleva o potencial para inconsistências)

    // Pode haver uma abordagem híbrida (Repository Genérico com específico):
    // Combinar repositórios genéricos para operações de acesso a dados comuns e repositórios específicos quando funcionalidades personalizadas são necessárias para entidades específicas

    // Nessa abordagem podemos:
    // Criar um repositório genérico para operações CRUD comuns usadas
    // Criar um repositório específico para operações especificas para cada entidade
    // Herdar o repositório específico do repositório genérico

    // Usando interface ela nos permite ter varias implementações diferentes para esse repositorio, Ex.: podemos ter um repositorio que armazena dados de um banco de dados SQL ou em memoria, porque não temos uma implementação aqui
    // Boas praticas: é uma convenção usar o PascalCase, Exemplos: MinhaVariavel, ClassePrincipal e MetodoDeExemplo.


    // Antes do abordagem hibrida:

    //IEnumerable<Categoria> GetCategorias();
    //Categoria GetCategoria(int id);

    //Categoria Create(Categoria categoria); // não colocamos CreateCategoria, porque como já estamos tratando com o repositorio de categoria isso fica implicito, podemos usa-la porém é definido pela equipe e quando adotamos essa abordagem ela deve ser consistente em todo o projeto

    //Categoria Update(Categoria categoria);

    //Categoria Delete(int id);

    Task<IPagedList<Categoria>> GetCategoriasAsync(CategoriasParameters categoriasParameters);
    Task<IPagedList<Categoria>> GetCategoriasFiltroNomeAsync(CategoriasFiltroNome categoriasFiltroNome);

}
