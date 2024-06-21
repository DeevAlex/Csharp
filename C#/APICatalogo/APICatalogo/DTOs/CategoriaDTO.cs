using System.ComponentModel.DataAnnotations;

namespace APICatalogo.DTOs;

public class CategoriaDTO
{
    public int CategoriaId { get; set; }

    // O string? significa que é nullable porque o nullable está ativado fazendo assim que as propriedades por referencia tem que ser nullable
    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }

    [Required] // Indicando que a coluna vai ser NOT NULL
    [StringLength(300)] // Tamanho em bytes como 300
    public string? ImagemUrl { get; set; }

}
