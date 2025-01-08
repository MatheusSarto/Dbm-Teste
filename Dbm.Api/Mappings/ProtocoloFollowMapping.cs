using Dbm.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dbm.Api.Mappings
{
    public class ProtocoloFollowMapping : IEntityTypeConfiguration<ProtocoloFollow>
    {
        public void Configure(EntityTypeBuilder<ProtocoloFollow> builder)
        {
            builder.ToTable("ProtocoloFollow");
            builder.HasKey(pf => pf.IdFollow);

            builder.Property(pf => pf.IdFollow)
                .IsRequired()
                .HasColumnType("BIGINT")
                .ValueGeneratedOnAdd();

            builder.Property(pf => pf.ProtocoloId)
                .IsRequired()
                .HasColumnType("BIGINT");

            builder.Property(pf => pf.DescricaoAcao)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(280);

            builder.Property(pf => pf.DataAcao)
                .IsRequired()
                .HasColumnType("DATETIME")
                .HasDefaultValueSql("getdate()");

            builder.HasOne(pf => pf.Protocolo)
                .WithMany(p => p.ProtocoloFollows)
                .HasForeignKey(p => p.ProtocoloId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
