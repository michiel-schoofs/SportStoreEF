using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsStore.Models;

namespace SportStoreEF.Data.Mappers {
    class CategoryConfiguration : IEntityTypeConfiguration<Category> {
        public void Configure(EntityTypeBuilder<Category> builder) {
            builder.ToTable("Category");

            builder.HasMany(c => c.ProductCategories)
                .WithOne(c => c.Category)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(cp => cp.CategoryId);

            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);

            builder.Ignore(c => c.Products);
        }
    }
}
