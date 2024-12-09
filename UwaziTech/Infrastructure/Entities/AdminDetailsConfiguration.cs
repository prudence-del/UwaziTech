using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UwaziTech.Core.Models.request;

namespace UwaziTech.Infrastructure.Entities;

public class AdminDetailsConfiguration : IEntityTypeConfiguration<AdminDetails>
{
    public void Configure(EntityTypeBuilder<AdminDetails> builder)
    {
        builder.HasKey(u => u.Reference);
        
        builder.Property(u => u.Role).HasMaxLength(30);
        builder.Property(u => u.Username).HasMaxLength(30);
        builder.Property(u => u.Password).HasMaxLength(15);
        builder.Property(u => u.InsuranceName).HasMaxLength(30);
    }
}
