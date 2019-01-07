using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsStore.Models;

namespace SportStoreEF.Data.Mappers {
    class OnlineProductConfiguration : IEntityTypeConfiguration<OnlineProduct> {
        public void Configure(EntityTypeBuilder<OnlineProduct> builder) {
            builder.Property(op => op.ThumbNail).HasMaxLength(100);
        }
    }
}
