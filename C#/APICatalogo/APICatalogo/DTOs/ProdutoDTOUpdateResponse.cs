using APICatalogo.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APICatalogo.DTOs;

public class ProdutoDTOUpdateResponse
{

    public int ProdutoId { get; set; } // aqui será a chave primaria, tem que ser chamada ProdutoId ou Id

    public string? Nome { get; set; }

    public string? Descricao { get; set; }

    public decimal Preco { get; set; }

    public string? ImagemUrl { get; set; }

    public int Estoque { get; set; }
    public DateTime DataCadastro { get; set; }


    // Incluimos uma propriedade CategoriaId que mapeia para a chave estrangeira no banco de dados e uma propriedade de navegação Categoria para indicar que um Produto está relacionado com uma Categoria
    public int CategoriaId { get; set; } // Mapeia

}
