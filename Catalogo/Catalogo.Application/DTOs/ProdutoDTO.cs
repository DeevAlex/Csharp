using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Application.DTOs;

public class ProdutoDTO
{

    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatorio")]
    [MinLength(3)]
    [MaxLength(100)]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "A descriçao é obrigatorio")]
    [MinLength(5)]
    [MaxLength(200)]
    public string? Descricao { get; set; }

    [Required(ErrorMessage = "Informe o preço")]
    public decimal Preco { get; set; }

    [MaxLength(250)]
    public decimal ImagemUrl { get; set; } 

    [Required(ErrorMessage = "O estoque é obrigatorio")]
    public int Estoque { get; set; }


}
