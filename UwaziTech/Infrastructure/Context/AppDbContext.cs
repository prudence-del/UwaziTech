using Microsoft.EntityFrameworkCore;
using System.Reflection;
using UwaziTech.Core.Models.request;

namespace UwaziTech.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }


        //Adding DBset properties for my tables
        public DbSet<UserDetails> UserDetail { get; set; }
        public DbSet<AdminDetails> AdminDetail { get; set; }
        public DbSet<InvoiceDetails> InvoiceDetails { get; set; }
        
        public DbSet<HospitalDetails> HospitalDetail { get; set; }
        public DbSet<InsuranceDetails> InsuranceDetail { get; set; }
        
        public DbSet<HospitalAdminDetails> HospitalAdminDetail { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDetails>().Property(x => x.Reference);
            modelBuilder.Entity<InsuranceDetails>().HasKey(e => e.Reference);
            modelBuilder.Entity<AdminDetails>().HasKey(e => e.Reference);
            modelBuilder.Entity<InvoiceDetails>().HasKey(e => e.Reference);
            modelBuilder.Entity<HospitalDetails>().HasKey(e => e.Reference);
            modelBuilder.Entity<HospitalAdminDetails>().HasKey(e => e.Reference);
        }
    }
}
