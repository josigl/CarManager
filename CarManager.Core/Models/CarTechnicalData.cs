using CarManager.Core.Enums;

namespace CarManager.Core.Models
{
    public class CarTechnicalData
    {
        // Relationship
        public int CarId { get; set; }


        // General Technical Data
        public int PowerKw { get; set; }
        public int TorqueNm { get; set; }
        public decimal Acceleration { get; set; }
        public int TopSpeedKmh { get; set; }
        public CarTransmissionType TransmissionType { get; set; }
        public CarDriveType DriveType { get; set; }
        public CarFuelType? FuelType { get; set; }
        public int CurbWeightKg { get; set; }
        public int TrunkCapacityLiters { get; set; }
        public string ExteriorColor { get; set; } = null!;
        public string InteriorColor { get; set; } = null!;
        public CarPowerTrain PowerTrain { get; set; }


        // Combustion / Hybrid / PHEV
        public string? EngineType { get; set; }
        public int? DisplacementCc { get; set; }
        public int? Cylinders { get; set; }

        public int? FuelTankCapacityLiters { get; set; }
        public decimal? FuelConsumption { get; set; }

        public int? Co2Emissions { get; set; }
        public string? EmissionStandard { get; set; }


        // Electric
        public string? MotorType { get; set; }

        public decimal? BatteryCapacityKwh { get; set; }
        public decimal? UsableBatteryCapacityKwh { get; set; }

        public int? ElectricRangeKm { get; set; }

        public decimal? EnergyConsumption { get; set; }

        public decimal? ChargingPowerAcKw { get; set; }
        public decimal? ChargingPowerDcKw { get; set; }


        // Hybrid-specific
        public string? BatteryType { get; set; }


    }
}
