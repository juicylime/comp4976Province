using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Province.Models;


namespace Province.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<City> ().Property (m => m.ProvinceCode).IsRequired();
            builder.Entity<Provinces> ().Property (p => p.ProvinceCode).HasMaxLength(30);
        
            builder.Entity<City>().ToTable("City");
            builder.Entity<Provinces>().ToTable("Provinces");
            

            builder.Seed();
        }
        public DbSet<Provinces> Provinces {get;set;}
        public DbSet<City> Cities {get;set;}

    }
}
