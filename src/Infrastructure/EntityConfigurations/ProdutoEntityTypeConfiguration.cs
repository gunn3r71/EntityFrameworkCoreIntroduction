using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations
{
    internal class ProdutoEntityTypeConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CodigoBarras)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(x => x.Tipo)
                .HasColumnType("int")
                .IsRequired();
            builder.Property(x => x.Descricao)
                .HasMaxLength(200);
            builder.Property(x => x.Status)
                .IsRequired();
            builder.Property(x => x.Valor)
                .IsRequired();
        }
    }
}
