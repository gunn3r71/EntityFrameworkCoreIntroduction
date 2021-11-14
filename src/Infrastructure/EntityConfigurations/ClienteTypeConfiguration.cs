using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntitiesTypesConfigurations
{
    internal class ClienteTypeConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.Telefone)
                .IsRequired()
                .HasMaxLength(11);
            builder.Property(x => x.Cep)
                .IsRequired()
                .HasMaxLength(8);
            builder.Property(x => x.Cidade)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.Estado)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(x => x.Pedidos)
                .WithOne(x => x.Cliente)
                .HasForeignKey(x => x.ClienteId);
        }
    }
}
