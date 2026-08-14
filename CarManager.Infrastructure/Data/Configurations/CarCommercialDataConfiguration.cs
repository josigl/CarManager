using CarManager.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarManager.Infrastructure.Data.Configurations
{
    public class CarCommercialDataConfiguration : IEntityTypeConfiguration<CarCommercialData>
    {
        public void Configure(EntityTypeBuilder<CarCommercialData> builder)
        {
            builder.ToTable("CarCommercialData");

            builder.HasKey(x => x.CarId);

            // Price / Value
            builder.Property(x => x.CurrentValue)
                .HasPrecision(10, 2);

            builder.Property(x => x.PurchasePrice)
                .HasPrecision(10, 2);

            // Purchase Information
            builder.Property(x => x.Dealer)
                .HasMaxLength(50);

            builder.Property(x => x.InvoiceNo)
                .HasMaxLength(30);

            // Annual Running Costs
            builder.Property(x => x.AnnualInsuranceCost)
                .HasPrecision(8, 2);

            builder.Property(x => x.AnnualRoadTax)
                .HasPrecision(8, 2);

            builder.Property(x => x.AnnualFuelCost)
                .HasPrecision(8, 2);

            builder.Property(x => x.AnnualMaintenanceCost)
                .HasPrecision(8, 2);
        }
    }
}
