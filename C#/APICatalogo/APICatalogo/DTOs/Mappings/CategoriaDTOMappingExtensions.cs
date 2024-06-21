﻿using APICatalogo.Models;

namespace APICatalogo.DTOs.Mappings;

public static class CategoriaDTOMappingExtensions
{

    // ? significa que pode armazenar valores null
    public static CategoriaDTO? ToCategoriaDTO(this Categoria categoria)
    {

        if (categoria == null) return null;

        return new CategoriaDTO()
        {
            CategoriaId = categoria.CategoriaId,
            Nome = categoria.Nome,
            ImagemUrl = categoria.ImagemUrl,
        };

    }

    public static Categoria? ToCategoria(this CategoriaDTO categoriaDTO)
    {

        if (categoriaDTO == null) return null;

        return new Categoria()
        {
            CategoriaId = categoriaDTO.CategoriaId,
            Nome = categoriaDTO.Nome,
            ImagemUrl = categoriaDTO.ImagemUrl,
        };

    }

    public static IEnumerable<CategoriaDTO> ToCategoriaDTOList(this IEnumerable<Categoria> categorias)
    {
        if (categorias == null || !categorias.Any()) return new List<CategoriaDTO>();

        // Converte cada objeto da lista categorias para CategoriaDTO fazendo um mapeamento e no fim retorna uma lista de objetos CategoriaDTO
        return categorias.Select(c => new CategoriaDTO() 
        {
            CategoriaId = c.CategoriaId,
            Nome = c.Nome,
            ImagemUrl = c.ImagemUrl,
        }).ToList();
    }

}
