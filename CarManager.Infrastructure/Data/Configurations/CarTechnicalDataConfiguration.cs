using CarManager.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarManager.Infrastructure.Data.Configurations
{
    public class CarTechnicalDataConfiguration : IEntityTypeConfiguration<CarTechnicalData>
    {
        public void Configure(EntityTypeBuilder<CarTechnicalData> builder)
        {
            builder.ToTable("CarTechnicalData");

            builder.HasKey(x => x.CarId);

            // General Technical Data
            builder.Property(x => x.Acceleration)
                .HasPrecision(4, 2);

            builder.Property(x => x.ExteriorColor)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.InteriorColor)
                .HasMaxLength(50)
                .IsRequired();


            // Combustion / Hybrid / PHEV
            builder.Property(x => x.EngineType)
                .HasMaxLength(100);

            builder.Property(x => x.FuelConsumption)
                .HasPrecision(5, 2);

            builder.Property(x => x.EmissionStandard)
                .HasMaxLength(30);


            // Electric
            builder.Property(x => x.MotorType)
                .HasMaxLength(100);

            builder.Property(x => x.BatteryCapacityKwh)
                .HasPrecision(6, 2);

            builder.Property(x => x.UsableBatteryCapacityKwh)
                .HasPrecision(6, 2);

            builder.Property(x => x.EnergyConsumption)
                .HasPrecision(5, 2);

            builder.Property(x => x.ChargingPowerAcKw)
                .HasPrecision(6, 2);

            builder.Property(x => x.ChargingPowerDcKw)
                .HasPrecision(6, 2);


            // Hybrid-specific
            builder.Property(x => x.BatteryType)
                .HasMaxLength(50);

        }
    }
}
