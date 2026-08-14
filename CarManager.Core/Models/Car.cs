using CarManager.Core.Enums;

namespace CarManager.Core.Models
{
    public class Car
    {
        public int Id { get; set; }
        public CarStatus Status { get; set; }
        public required string Make { get; set; }
        public required string Model { get; set; }
        public string? Variant { get; set; }
        public CarBodyType BodyType { get; set; }
        public int ModelYear { get; set; }
        public DateTime FirstRegistration { get; set; }
        public required string Vin { get; set; }
        public string? LicensePlate { get; set; }
        public CarCondition Condition { get; set; }
        public int PreviousOwners { get; set; }
        public string? Location { get; set; }

        public required CarTechnicalData TechnicalData { get; set; }
        public required CarCommercialData CommercialData { get; set; }

        public ICollection<CarTimelineItem> TimelineItems { get; set; } = new List<CarTimelineItem>();

    }
}
