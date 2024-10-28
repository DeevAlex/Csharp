using Catalogo.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Domain.Entities;

public sealed class Categoria : Entity // sealed -> indica que a classe não podera ser herdada, isso é uma forma de isolar a entidade do mundo externo encapsulando-a
{

    public Categoria(string nome, string imagemUrl) 
    {
        ValidateDomain(nome, imagemUrl);
    }

    // criado apenas para popular a tabela categorias com dados
    public Categoria(int id, string nome, string imagemUrl)
    {
        DomainExceptionValidation.When(id < 0, "valor de id invalido");
        Id = id;
        ValidateDomain(nome, imagemUrl);
    }

    public string Nome { get; private set; } // private set -> garante que o valor para estas propriedades só poderam ser atribuidas via construtor, e assim elas estarão isoladas de todos os projetos da solução, com relação a atribuição de valores
    public string ImagemUrl { get; private set; }
    public ICollection<Produto> Produtos { get; set; }
    
    // o bojetivo é fazer a validação das regras de negocio do modelo
    private void ValidateDomain(string nome, string imagemUrl)
    {

        DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome invalido. o nome é obrigatorio");
        DomainExceptionValidation.When(string.IsNullOrEmpty(imagemUrl), "Nome da imagem invalido. o nome é obrigatorio");
        DomainExceptionValidation.When(nome.Length < 3, "O nome deve ter no minimo 3 caracteres");
        DomainExceptionValidation.When(imagemUrl.Length < 5, "O nome da imagem deve ter no minimo 3 caracteres");

        Nome = nome;
        ImagemUrl = imagemUrl;

    }

}
