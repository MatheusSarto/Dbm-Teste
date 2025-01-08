using Dbm.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dbm.Api.Mappings
{
    public class ProtocoloMapping : IEntityTypeConfiguration<Protocolo>
    {
        public void Configure(EntityTypeBuilder<Protocolo> builder)
        {
            builder.ToTable("Protocolo");

            builder.HasKey(p => p.IdProtocolo);
            builder.Property(p => p.IdProtocolo)
                .IsRequired()
                .HasColumnType("BIGINT")
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Titulo)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(128);

            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(280);

            builder.Property(p => p.DataAbertura)
                .IsRequired()
                .HasColumnType("DATETIME")
                .HasDefaultValueSql("getdate()");

            builder.Property(p => p.DataFechamento)
                .IsRequired(false)
                .HasColumnType("DATETIME");

            builder.Property(p => p.ClienteId)
            .IsRequired()
            .HasColumnType("BIGINT")
            .ValueGeneratedOnAdd();

            builder.Property(p => p.ProtocoloStatusId)
            .IsRequired()
            .HasColumnType("BIGINT")
            .ValueGeneratedOnAdd();

            builder.HasOne(p => p.Cliente)
                .WithMany(c => c.Protocolos)
                .HasForeignKey(p => p.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.ProtocoloStatus)
                .WithMany(pf => pf.Protocolos)
                .HasForeignKey(p => p.IdProtocolo)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
