using Catalogo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Infraestructure.EntitiesConfigurations;

internal class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {

        builder.HasKey(x => x.Id); // utilizando a fluentApi para definir a configuração de propriedade
        builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();
        builder.Property(p => p.Descricao).HasMaxLength(200).IsRequired();

        builder.Property(p => p.Preco).HasPrecision(10, 2);
        builder.Property(p => p.ImagemUrl).HasMaxLength(200);
        builder.Property(p => p.Estoque).HasDefaultValue(1).IsRequired();
        builder.Property(p => p.DataCadastro).IsRequired();

        // utilizando a fluentApi para definir o relacionamento entre Produto e Categoria
        builder.HasOne(e => e.Categoria).WithMany(e => e.Produtos).HasForeignKey(e => e.CategoriaId);

    }
}
