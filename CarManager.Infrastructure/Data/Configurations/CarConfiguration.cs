using CarManager.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarManager.Infrastructure.Data.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Car");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn(seed: 1001, increment: 1);

            builder.Property(x => x.Make)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Model)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Variant)
                .HasMaxLength(100);

            builder.Property(x => x.Vin)
                .HasMaxLength(17)
                .IsRequired();

            builder.HasIndex(x => x.Vin)
                .IsUnique();

            builder.Property(x => x.LicensePlate)
                .HasMaxLength(20);

            builder.Property(x => x.Location)
                .HasMaxLength(100);

            builder.HasOne(x => x.TechnicalData)
                .WithOne()
                .HasForeignKey<CarTechnicalData>(x => x.CarId);

            builder.HasOne(x => x.CommercialData)
                .WithOne()
                .HasForeignKey<CarCommercialData>(x => x.CarId);

            builder.HasMany(x => x.TimelineItems)
                .WithOne()
                .HasForeignKey(x => x.CarId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
