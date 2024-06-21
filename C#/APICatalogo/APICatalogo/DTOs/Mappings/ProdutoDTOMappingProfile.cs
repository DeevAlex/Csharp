using APICatalogo.Models;
using AutoMapper;

namespace APICatalogo.DTOs.Mappings;

// Classe de perfil, devemos herdar a classe Profile do AutoMapper
public class ProdutoDTOMappingProfile : Profile
{
    public ProdutoDTOMappingProfile()
    {

        // Aqui é onde definimos o mapeamento

        CreateMap<Produto, ProdutoDTO>().ReverseMap(); // mapeando de produto para produtoDTO, o metodo 'ReverseMap' ele faz os dois mapeamentos de um para outro sem a necessidade de fazer outro map 
        CreateMap<Categoria, CategoriaDTO>().ReverseMap();

        CreateMap<Produto, ProdutoDTOUpdateRequest>().ReverseMap();
        CreateMap<Produto, ProdutoDTOUpdateResponse>().ReverseMap();

    }
}
