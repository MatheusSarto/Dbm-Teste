using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Dbm.Core.Models;

namespace Dbm.Api.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(c => c.IdCliente);
            builder.Property(c => c.IdCliente)
                .IsRequired()
                .HasColumnType("BIGINT")
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Telefone)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(15);

            builder.Property(c => c.Email)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(c => c.Endereco)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(255);
        }
    }
}
