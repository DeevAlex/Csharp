using AutoMapper;
using Catalogo.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Domain.Entities;

namespace Catalogo.Application.Mappings;

public class DomainToDTOMappingProfile : Profile
{

    public DomainToDTOMappingProfile() 
    {
        CreateMap<Categoria, CategoriaDTO>().ReverseMap();
        CreateMap<Produto, ProdutoDTO>().ReverseMap();
    }

}
