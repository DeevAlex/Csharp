using Catalogo.Domain.Entities;
using Catalogo.Domain.Interfaces;
using Catalogo.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Infraestructure.Repositories;

public class ProdutoRepository : IProdutoRepository
{
    private ApplicationDbContext _productContext;
    public ProdutoRepository(ApplicationDbContext context)
    {
        _productContext = context;
    }

    public async Task<Produto> CreateAsync(Produto product)
    {
        _productContext.Add(product);
        await _productContext.SaveChangesAsync();
        return product;
    }

    public async Task<Produto> GetByIdAsync(int? id)
    {
        //return await _productContext.Produtos.FindAsync(id);
        return await _productContext.Produtos.Include(c => c.Categoria)
           .SingleOrDefaultAsync(p => p.Id == id);
    }

    public async Task<IEnumerable<Produto>> GetProdutosAsync()
    {
        return await _productContext.Produtos.ToListAsync();
    }

    public async Task<Produto> RemoveAsync(Produto product)
    {
        _productContext.Remove(product);
        await _productContext.SaveChangesAsync();
        return product;
    }

    public async Task<Produto> UpdateAsync(Produto product)
    {
        _productContext.Update(product);
        await _productContext.SaveChangesAsync();
        return product;
    }
}
