using CarManager.Core.Models;

namespace CarManager.WPF.ViewModels.CarDetails
{
    public class CommercialTabViewModel
    {
        public CommercialTabViewModel(CarCommercialData commercialData, IEnumerable<CarTimelineItem> timelineItems)
        {
            CommercialData = commercialData;
            TimelineItems = timelineItems;
        }

        public CarCommercialData CommercialData { get; init; }
        public IEnumerable<CarTimelineItem> TimelineItems { get; init; }

        public string PurchasePriceInfo => $"Purchased {CommercialData.PurchaseDate:yyyy-MM-dd}";

        public decimal ValueChange => CommercialData.CurrentValue - CommercialData.PurchasePrice;
        public decimal ValueChangePercentageAbsolute => Math.Abs(ValueChangePercentage);
        public decimal ValueChangePercentage => Math.Round((ValueChange / CommercialData.PurchasePrice) * 100, 1);
        public decimal AnnualRunningCosts => CommercialData.AnnualInsuranceCost + CommercialData.AnnualRoadTax + CommercialData.AnnualMaintenanceCost + CommercialData.AnnualFuelCost;

        public decimal AnnualRunningCostsPerMonth => AnnualRunningCosts / 12;
    }
}
