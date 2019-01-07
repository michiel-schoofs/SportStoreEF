using Microsoft.EntityFrameworkCore;
using SportsStore.Models;
using SportStoreEF.Data.Mappers;

namespace SportStoreEF {
    public class ApplicationDbContext :DbContext{
        public DbSet<Product> products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            var connectionString = @"Server=.\SQLEXPRESS;Database=SportStoreex7;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration<Product>(new ProductConfiguration())
                .ApplyConfiguration<City>(new CityConfiguration())
                .ApplyConfiguration<Customer>(new CustomerConfiguration())
                .ApplyConfiguration<Order>(new OrderConfiguration())
                .ApplyConfiguration<OrderLine>(new OrderLineConfiguration())
                .ApplyConfiguration<Category>(new CategoryConfiguration())
                .ApplyConfiguration<ProductCategory>(new CategoryProductConfiguration())
                .ApplyConfiguration<OnlineProduct>(new OnlineProductConfiguration());
        }
    }
}
