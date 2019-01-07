using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsStore.Models;

namespace SportStoreEF.Data.Mappers {
    class CityConfiguration : IEntityTypeConfiguration<City> {
        public void Configure(EntityTypeBuilder<City> builder) {
            builder.ToTable("City");

            builder.Property(c => c.Postalcode).HasMaxLength(5);
            builder.HasKey(c => c.Postalcode);

            builder.Property(c => c.Name).HasMaxLength(100).IsRequired();
        }
    }
}
