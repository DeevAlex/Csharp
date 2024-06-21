using APICatalogo.Models;

namespace APICatalogo.Repositories;

public interface IUnitOfWork
{

    // Unit Of Work : Utilidade
    //    - Gerenciar as transagoes 
    //    - Ordenar o CRUD no banco de dados 
    //    - Impedir a concorréncia(duplicacdo de atualizacbes) 
    //    - Usar somente uma instancia do contexto por requisicao 

    // usando o generico daria mais flexibilidade e reusabilidade no codigo só que fazendo essa abordagem perderiamos a capacidade de implementar metodos personalizados nos repositorios especificos
    //Repository<Produto> ProdutoRepository { get; }
    //Repository<Categoria> CategoriaRepository { get; }

    // usando propriedade ao invés de usar metodo, porque é uma maneira conveniente nesse contexto de expor essas funcionalidades para quem vai usar a implementação padrão Unit Of Work, quando usamos propriedades incapsulamos o acesso aos repositorios e permitimos um maior controle da forma como eles serão expostos e utilizados e podemos utilizar essas propriedades como se eles fossem campos publicos então o codigo fica mais limpo e mais facil de entender e também é mais facil substituir os repositorios quando formos fazer os testes de unidade
    IProdutoRepository ProdutoRepository { get; } // aqui temos um metodo personalizado, então se usarmos o repositorio acima o perderiamos
    ICategoriaRepository CategoriaRepository { get; }

    Task CommitAsync(); // pode ser qualquer nome, ele é quem vai salvar as alterações/adicões no banco de dados

}
