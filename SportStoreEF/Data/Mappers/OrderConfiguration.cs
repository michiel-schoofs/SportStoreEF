using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsStore.Models;

namespace SportStoreEF.Data.Mappers {
    class OrderConfiguration : IEntityTypeConfiguration<Order> {
        public void Configure(EntityTypeBuilder<Order> builder) {
            builder.ToTable("Order");

            builder.HasOne(o => o.ShippingCity)
                .WithMany()
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(o => o.OrderDate).IsRequired();

            builder.Property(o => o.ShippingStreet).IsRequired().HasMaxLength(100);

            builder.HasMany(o => o.OrderLines).WithOne().HasForeignKey(ol => ol.OrderId);
        }
    }
}
