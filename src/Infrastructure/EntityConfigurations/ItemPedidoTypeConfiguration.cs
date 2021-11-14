using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations
{
    internal class ItemPedidoTypeConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Quantidade)
                .IsRequired();
            builder.Property(x => x.Valor)
                .IsRequired();
            builder.HasOne(x => x.Pedido)
                .WithMany()
                .HasForeignKey(x => x.PedidoId)
                .HasPrincipalKey(x => x.Id);
        }
    }
}
