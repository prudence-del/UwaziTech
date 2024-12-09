using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UwaziTech.Core.Models.request;

namespace UwaziTech.Infrastructure.Entities;

public class UserDetailsConfiguration : IEntityTypeConfiguration<UserDetails>
{
    public void Configure(EntityTypeBuilder<UserDetails> builder)
    {
        builder.HasKey(u => u.Reference);
        
        builder.Property(u => u.BranchName).HasMaxLength(50);
        builder.Property(u => u.Username).HasMaxLength(50);
        builder.Property(u => u.Password).HasMaxLength(20);
    }
}