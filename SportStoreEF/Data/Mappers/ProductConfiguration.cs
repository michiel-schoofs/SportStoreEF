using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsStore.Models;

namespace SportStoreEF.Data.Mappers {
    class ProductConfiguration : IEntityTypeConfiguration<Product> {
        public void Configure(EntityTypeBuilder<Product> builder) {
            builder.ToTable("Product");

            builder
                .HasDiscriminator<string>("Discriminator")
                .HasValue<Product>("Product")
                .HasValue<OnlineProduct>("OnlineProduct");

            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
        }
    }
}
