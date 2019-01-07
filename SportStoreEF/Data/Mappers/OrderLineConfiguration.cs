using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsStore.Models;

namespace SportStoreEF.Data.Mappers {
    class OrderLineConfiguration : IEntityTypeConfiguration<OrderLine> {
        public void Configure(EntityTypeBuilder<OrderLine> builder) {
            builder.ToTable("OrderLine");

            builder.HasKey(ol => new { ol.OrderId, ol.ProductId });

            builder
                .HasOne(ol => ol.Product)
                .WithMany()
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(ol => ol.ProductId);
        }
    }
}
