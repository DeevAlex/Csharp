using Catalogo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Infraestructure.EntitiesConfigurations;

internal class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        builder.HasKey(x => x.Id); // utilizando a fluentApi
        builder.Property(c => c.Nome).HasMaxLength(100).IsRequired();
        builder.Property(c => c.ImagemUrl).HasMaxLength(100).IsRequired();

        // utilizando HasData para popular a tabela categorias que foi mapeada para entidade Categoria
        builder.HasData(
            new Categoria(1, "Material Escolar", "material.jpg"),
            new Categoria(2, "Eletronicos", "eletronicos.jpg"),
            new Categoria(3, "Acessorios", "acessorios.jpg")
        );
    }
}
