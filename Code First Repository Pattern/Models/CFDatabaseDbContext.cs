using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Code_First_Repository_Pattern.Models
{
    public class CFDatabaseDbContext : DbContext
    {
        public CFDatabaseDbContext():base("CFDatabase")
        {
           // Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CFDatabaseDbContext>());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasKey<int>(k => k.CategoryId);
            modelBuilder.Entity<Product>().HasKey<int>(k => k.ProductId);

        }
    }
}