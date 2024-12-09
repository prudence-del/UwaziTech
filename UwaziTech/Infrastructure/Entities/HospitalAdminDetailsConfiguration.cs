using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UwaziTech.Core.Models.request;

namespace UwaziTech.Infrastructure.Entities;

public class HospitalAdminDetailsConfiguration : IEntityTypeConfiguration<HospitalAdminDetails>
{
    public void Configure(EntityTypeBuilder<HospitalAdminDetails> builder)
    {
        builder.HasKey(x => x.Reference);
        
        builder.Property(x => x.Hospital).HasMaxLength(100);
        builder.Property(x => x.Role).HasMaxLength(100);
        builder.Property(x => x.Username).HasMaxLength(100);
        builder.Property(x => x.Password).HasMaxLength(100);
    }
}