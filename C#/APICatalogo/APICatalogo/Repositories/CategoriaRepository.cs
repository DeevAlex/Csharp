using APICatalogo.Context;
using APICatalogo.Models;
using APICatalogo.Pagination;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace APICatalogo.Repositories;

// vai continuar implementando a interface 'ICategoriaRepository' só que ela vai herdar da classe concreta 'Repository'
public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
{

    // Aqui não deve ter a logica de negocio

    // Objetivo do repositorio: é centralizar a logica de acesso a dados
    // Até o momento da aula 74 isso está sendo feito no controlador, nos injetamos a instancia da nossa classe de contexto 'AppDbContext' no construtor do controlador e recebendo a instancia da classe de contexto e através dela acessando os dados lá tem o mapeamento das tabelas, a partir de agora vamos colocar no repositorio

    public CategoriaRepository(AppDbContext context) : base(context) // se precisar use o contexto herdado da classe base (classe Repository), a palavra-chave base é usada para acessar membros de classe base de dentro de uma classe derivada
    {
    }

    public async Task<IPagedList<Categoria>> GetCategoriasAsync(CategoriasParameters categoriasParameters)
    {

        var categorias = await GetAllAsync();

        var categoriasOrdenadas = categorias.OrderBy(c => c.CategoriaId).AsQueryable(); // fizemos em partes, porque a ordenação é feita localmente na memoria e não precisamos de uma operação assíncrona para fazer tal ação

        //var resultado = PagedList<Categoria>.ToPagedList(categoriasOrdenadas, categoriasParameters.PageNumber, categoriasParameters.PageSize); // criando uma instancia de 'PagedList' de Produtos fazendo a ordenação

        // Codigo para fazer a paginação assíncrona, usando o Pacote X.PagedList
        var resultado = await categoriasOrdenadas.ToPagedListAsync(categoriasParameters.PageNumber, categoriasParameters.PageSize);

        return resultado;

    }

    public async Task<IPagedList<Categoria>> GetCategoriasFiltroNomeAsync(CategoriasFiltroNome categoriasFiltroNomeParams)
    {

        var categorias = await GetAllAsync();

        if (!string.IsNullOrEmpty(categoriasFiltroNomeParams.Nome))
        {
            categorias = categorias.Where(c => c.Nome.Contains(categoriasFiltroNomeParams.Nome)); // vai retonar todas as categorias que contiverem um trecho do nome ou ele inteiro
        }

        // Sincrona, Devemos usar com a interface PagedList
        //var categoriasFiltradas = PagedList<Categoria>.ToPagedList(categorias.AsQueryable(), categoriasFiltroNome.PageNumber, categoriasFiltroNome.PageSize);

        // Codigo para fazer a paginação assíncrona
        var categoriasFiltradas = await categorias.ToPagedListAsync(categoriasFiltroNomeParams.PageNumber, categoriasFiltroNomeParams.PageSize);

        return categoriasFiltradas;

    }
}
