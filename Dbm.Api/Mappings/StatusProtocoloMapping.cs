using Dbm.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dbm.Api.Mappings
{
    public class StatusProtocoloMapping : IEntityTypeConfiguration<StatusProtocolo>
    {
        public void Configure(EntityTypeBuilder<StatusProtocolo> builder)
        {
            builder.HasKey(pf => pf.IdStatus);

            builder.Property(pf => pf.IdStatus)
                .IsRequired()
                .HasColumnType("BIGINT")
                .ValueGeneratedOnAdd();

            builder.Property(pf => pf.NomeStatus)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);
        }
    }
}
