using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsStore.Models;

namespace SportStoreEF.Data.Mappers {
    class CustomerConfiguration : IEntityTypeConfiguration<Customer> {
        public void Configure(EntityTypeBuilder<Customer> builder) {
            builder.ToTable("Customer");

            builder
                .HasOne(c => c.City)
                .WithMany()
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(c => c.CustomerName).HasMaxLength(20).IsRequired();
            builder.Property(c => c.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Street).HasMaxLength(100);
        }
    }
}
