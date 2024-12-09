using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UwaziTech.Core.Models.request;

namespace UwaziTech.Infrastructure.Entities;

public class HospitalDetailsConfiguration : IEntityTypeConfiguration<HospitalDetails>
{
    public void Configure(EntityTypeBuilder<HospitalDetails> builder)
    {
        builder.HasKey(x => x.Reference);
        
        builder.Property(x => x.Address).HasColumnType("varchar(100)");
        builder.Property(x => x.Branch).HasColumnType("varchar(100)");
        builder.Property(x => x.HospitalName).HasColumnType("varchar(100)");
    }
}