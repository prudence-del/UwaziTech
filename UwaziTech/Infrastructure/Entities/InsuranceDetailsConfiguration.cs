using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UwaziTech.Core.Models.request;

namespace UwaziTech.Infrastructure.Entities;

public class InsuranceDetailsConfiguration : IEntityTypeConfiguration<InsuranceDetails>
{
    public void Configure(EntityTypeBuilder<InsuranceDetails> builder)
    {
        builder.HasKey(u => u.Reference);

        builder.Property(u => u.Name).HasMaxLength(30);
        builder.Property(u => u.Address).HasMaxLength(15);
        builder.Property(u => u.PhoneNumber).HasMaxLength(30);
    }
}
