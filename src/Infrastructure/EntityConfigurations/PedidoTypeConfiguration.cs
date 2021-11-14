using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations
{
    internal class PedidoTypeConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IniciadoEm)
                .IsRequired()
                .ValueGeneratedOnAdd();
            builder.Property(x => x.TipoFrete)
                .HasColumnType("int")
                .IsRequired();
            builder.Property(x => x.Status)
                .HasColumnType("int")
                .IsRequired();
            builder.Property(x => x.Observacao)
                .HasMaxLength(200);
            builder.HasMany(x => x.Itens)
                .WithOne(x => x.Pedido)
                .HasForeignKey(x => x.PedidoId)
                .HasPrincipalKey(x => x.Id);
        }
    }
}
