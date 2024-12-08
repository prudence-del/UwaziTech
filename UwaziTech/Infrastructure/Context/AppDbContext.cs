﻿using Microsoft.EntityFrameworkCore;
using System.Reflection;
using UwaziTech.Core.Models.request;

namespace UwaziTech.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }


        //Adding DBset properties for my tables
        public DbSet<AdminDetails> AdminDetail { get; set; }
        public DbSet<InsuranceDetails> InsuranceDetail { get; set; }
        public DbSet<InvoiceDetails> InvoiceDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InsuranceDetails>().HasKey(e => e.Id);
            modelBuilder.Entity<AdminDetails>().HasKey(e => e.Reference);
            modelBuilder.Entity<InvoiceDetails>().HasKey(e => e.Reference);
        }
    }
}