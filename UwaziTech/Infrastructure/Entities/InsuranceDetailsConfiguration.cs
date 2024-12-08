using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UwaziTech.Core.Models.request;

namespace UwaziTech.Infrastructure.Entities;

public class InsuranceDetailsConfiguration : IEntityTypeConfiguration<UserDetails>
{
    public void Configure(EntityTypeBuilder<UserDetails> builder)
    {
        builder.HasKey(u => u.Id);

        builder.Property(u => u.Username).HasMaxLength(30);
        builder.Property(u => u.Password).HasMaxLength(15);
        builder.Property(u => u.BranchName).HasMaxLength(30);
    }
}
