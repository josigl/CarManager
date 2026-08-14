using System;
using System.Collections.Generic;
using System.Text;

namespace CarManager.Core.Models
{
    public class CarCommercialData
    {
        // Relationship
        public int CarId { get; set; }

        // Price / Value
        public decimal CurrentValue { get; set; }
        public decimal PurchasePrice { get; set; }

        // Purchase Information
        public DateOnly PurchaseDate { get; set; }
        public string? Dealer { get; set; }
        public string? InvoiceNo{ get; set; }
        public DateOnly? WarrantyUntil { get; set; }

        // Annual Running Costs
        public decimal AnnualInsuranceCost { get; set; }
        public decimal AnnualRoadTax { get; set; }
        public decimal AnnualFuelCost { get; set; }
        public decimal AnnualMaintenanceCost { get; set; }
    }
}
