using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsStore.Models;

namespace SportStoreEF.Data.Mappers {
    class CategoryProductConfiguration : IEntityTypeConfiguration<ProductCategory> {
        public void Configure(EntityTypeBuilder<ProductCategory> builder) {
            builder.ToTable("CategoryProduct");

            builder.HasKey(pc => new { pc.CategoryId, pc.ProductId });

            builder
                .HasOne(cp => cp.Product)
                .WithMany()
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(cp=>cp.ProductId);
        }
    }
}
