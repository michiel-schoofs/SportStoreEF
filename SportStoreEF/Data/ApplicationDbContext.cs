using Microsoft.EntityFrameworkCore;
using SportsStore.Models;
using SportStoreEF.Data.Mappers;

namespace SportStoreEF {
    class ApplicationDbContext :DbContext{
        DbSet<Product> products { get; set; }
        DbSet<City> City { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            var connectionString = @"Server=.\SQLEXPRESS;Database=SportStoreex7;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration<Product>(new ProductConfiguration())
                .ApplyConfiguration<City>(new CityConfiguration());
        }
    }
}
