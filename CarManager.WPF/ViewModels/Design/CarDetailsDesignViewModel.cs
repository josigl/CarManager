using CarManager.Core.Enums;
using CarManager.Core.Models;
using CarManager.WPF.ViewModels.CarDetails;

namespace CarManager.WPF.ViewModels.Design
{
    public class CarDetailsDesignViewModel : CarDetailsViewModel
    {
        public CarDetailsDesignViewModel()
        {

            //Car = CreateCombustionCar();
            //Car = CreateElectricCar();
            //Car = CreateHybridCar();
            Car = CreatePlugInHybridCar();

            TechnicalTab = new TechnicalTabViewModel(Car.TechnicalData);
            CommercialTab = new CommercialTabViewModel(
                Car.CommercialData,
                Car.TimelineItems);

        }

        private static Car CreateCombustionCar()
        {
            return new Car
            {
                Id = 1001,
                Status = CarStatus.Available,
                Make = "Porsche",
                Model = "911",
                Variant = "GT3 RS",
                BodyType = CarBodyType.Coupe,
                ModelYear = 2026,
                Mileage = 1000,
                FirstRegistration = new DateTime(2026, 5, 15),
                Vin = "POR26C00000001001",
                LicensePlate = "D-CM 1001",
                Condition = CarCondition.Excellent,
                PreviousOwners = 1,
                Location = "Hamburg, Germany",

                TechnicalData = new CarTechnicalData
                {
                    PowerKw = 375,
                    TorqueNm = 450,
                    Acceleration = 3.90m,
                    TopSpeedKmh = 292,
                    TransmissionType = CarTransmissionType.Manual,
                    DriveType = CarDriveType.RWD,
                    FuelType = CarFuelType.Petrol,
                    CurbWeightKg = 1462,
                    TrunkCapacityLiters = 135,
                    ExteriorColor = "GT Silver Metallic",
                    InteriorColor = "Black / Guards Red",
                    PowerTrain = CarPowerTrain.ICE,

                    EngineType = "Naturally Aspirated Flat-6",
                    DisplacementCc = 3996,
                    Cylinders = 6,
                    FuelTankCapacityLiters = 64,
                    FuelConsumption = 13.0m,
                    Co2Emissions = 294,
                    EmissionStandard = "Euro 6e"
                },

                CommercialData = new CarCommercialData
                {
                    CurrentValue = 239500m,
                    PurchasePrice = 252000m,
                    PurchaseDate = new DateOnly(2025, 11, 20),
                    Dealer = "Porsche Zentrum Hamburg",
                    InvoiceNo = "PZH-2025-11842",
                    WarrantyUntil = new DateOnly(2028, 11, 20),
                    AnnualInsuranceCost = 4200m,
                    AnnualRoadTax = 486m,
                    AnnualFuelCost = 2400m,
                    AnnualMaintenanceCost = 3500m
                },

                TimelineItems = new List<CarTimelineItem>
                {
                    new()
                    {
                        Date = new DateOnly(2025, 11, 20),
                        Title = "Vehicle purchased",
                        Description = "Purchased from Porsche Zentrum Hamburg.",
                        IsCompleted = true
                    },
                    new()
                    {
                        Date = new DateOnly(2025, 11, 25),
                        Title = "First registration",
                        Description = "Vehicle registered in Hamburg.",
                        IsCompleted = true
                    },
                    new()
                    {
                        Date = new DateOnly(2026, 5, 15),
                        Title = "Annual inspection",
                        Description = "Inspection completed without findings.",
                        IsCompleted = true
                    },
                    new()
                    {
                        Date = new DateOnly(2026, 11, 15),
                        Title = "Next service",
                        Description = "Scheduled annual service.",
                        IsCompleted = false
                    }
                }
            };
        }


        private static Car CreateElectricCar()
        {
            return new Car
            {
                Id = 1016,
                Status = CarStatus.Available,
                Make = "Porsche",
                Model = "Taycan",
                Variant = "Turbo GT",
                BodyType = CarBodyType.Sedan,
                ModelYear = 2026,
                Mileage = 3200,
                FirstRegistration = new DateTime(2026, 3, 20),
                Vin = "POR26E00000001016",
                LicensePlate = "HH-TG 1016",
                Condition = CarCondition.Excellent,
                PreviousOwners = 0,
                Location = "Hamburg, Germany",

                TechnicalData = new CarTechnicalData
                {
                    PowerKw = 760,
                    TorqueNm = 1340,
                    Acceleration = 2.30m,
                    TopSpeedKmh = 305,
                    TransmissionType = CarTransmissionType.SingleSpeed,
                    DriveType = CarDriveType.AWD,
                    FuelType = null,
                    CurbWeightKg = 2290,
                    TrunkCapacityLiters = 367,
                    ExteriorColor = "Purple Sky Metallic",
                    InteriorColor = "Black",
                    PowerTrain = CarPowerTrain.BEV,

                    MotorType = "Dual Permanent Magnet Motors",
                    BatteryCapacityKwh = 105m,
                    UsableBatteryCapacityKwh = 97m,
                    ElectricRangeKm = 630,
                    EnergyConsumption = 18.7m,
                    ChargingPowerAcKw = 11m,
                    ChargingPowerDcKw = 320m
                },

                CommercialData = new CarCommercialData
                {
                    CurrentValue = 245000m,
                    PurchasePrice = 258500m,
                    PurchaseDate = new DateOnly(2026, 3, 10),
                    Dealer = "Porsche Zentrum Hamburg",
                    InvoiceNo = "PZH-2026-03116",
                    WarrantyUntil = new DateOnly(2029, 3, 10),
                    AnnualInsuranceCost = 3900m,
                    AnnualRoadTax = 0m,
                    AnnualFuelCost = 1450m,
                    AnnualMaintenanceCost = 2200m
                },

                TimelineItems = new List<CarTimelineItem>
                {
                    new()
                    {
                        Date = new DateOnly(2026, 3, 10),
                        Title = "Vehicle purchased",
                        Description = "Purchased as new vehicle.",
                        IsCompleted = true
                    },
                    new()
                    {
                        Date = new DateOnly(2026, 3, 20),
                        Title = "First registration",
                        Description = "Vehicle registered in Hamburg.",
                        IsCompleted = true
                    },
                    new()
                    {
                        Date = new DateOnly(2026, 6, 18),
                        Title = "Software update",
                        Description = "Vehicle software updated successfully.",
                        IsCompleted = true
                    },
                    new()
                    {
                        Date = new DateOnly(2027, 3, 20),
                        Title = "Scheduled inspection",
                        Description = "First annual inspection due.",
                        IsCompleted = false
                    }
                }
            };
        }


        private static Car CreateHybridCar()
        {
            return new Car
            {
                Id = 2001,
                Status = CarStatus.InUse,
                Make = "Lexus",
                Model = "LC 500h",
                Variant = "Luxury",
                BodyType = CarBodyType.Coupe,
                ModelYear = 2025,
                Mileage = 8400,
                FirstRegistration = new DateTime(2025, 10, 12),
                Vin = "LEX25H00000002001",
                LicensePlate = "HH-LC 500",
                Condition = CarCondition.Excellent,
                PreviousOwners = 1,
                Location = "Hamburg, Germany",

                TechnicalData = new CarTechnicalData
                {
                    PowerKw = 264,
                    TorqueNm = 350,
                    Acceleration = 5.0m,
                    TopSpeedKmh = 250,
                    TransmissionType = CarTransmissionType.Automatic,
                    DriveType = CarDriveType.RWD,
                    FuelType = CarFuelType.Petrol,
                    CurbWeightKg = 1985,
                    TrunkCapacityLiters = 172,
                    ExteriorColor = "Sonic Titanium",
                    InteriorColor = "Black Leather",
                    PowerTrain = CarPowerTrain.HEV,

                    EngineType = "3.5 l V6",
                    DisplacementCc = 3456,
                    Cylinders = 6,
                    BatteryType = "Lithium-Ion",
                    BatteryCapacityKwh = 1.1m,
                    FuelTankCapacityLiters = 82,
                    FuelConsumption = 7.2m,
                    Co2Emissions = 163,
                    EmissionStandard = "Euro 6e"
                },

                CommercialData = new CarCommercialData
                {
                    CurrentValue = 109500m,
                    PurchasePrice = 118000m,
                    PurchaseDate = new DateOnly(2025, 9, 25),
                    Dealer = "Lexus Hamburg",
                    InvoiceNo = "LEX-HH-250925",
                    WarrantyUntil = new DateOnly(2029, 9, 25),
                    AnnualInsuranceCost = 1850m,
                    AnnualRoadTax = 280m,
                    AnnualFuelCost = 1850m,
                    AnnualMaintenanceCost = 1700m
                },

                TimelineItems = new List<CarTimelineItem>
                {
                    new()
                    {
                        Date = new DateOnly(2025, 9, 25),
                        Title = "Vehicle purchased",
                        Description = "Purchased from Lexus Hamburg.",
                        IsCompleted = true
                    },
                    new()
                    {
                        Date = new DateOnly(2025, 10, 12),
                        Title = "First registration",
                        Description = "Vehicle registered and delivered.",
                        IsCompleted = true
                    },
                    new()
                    {
                        Date = new DateOnly(2026, 4, 18),
                        Title = "Maintenance",
                        Description = "Routine hybrid-system inspection completed.",
                        IsCompleted = true
                    },
                    new()
                    {
                        Date = new DateOnly(2026, 10, 12),
                        Title = "Annual service",
                        Description = "Annual service due.",
                        IsCompleted = false
                    }
                }
            };
        }


        private static Car CreatePlugInHybridCar()
        {
            return new Car
            {
                Id = 1020,
                Status = CarStatus.Available,
                Make = "Porsche",
                Model = "Panamera",
                Variant = "Turbo S E-Hybrid",
                BodyType = CarBodyType.Sedan,
                ModelYear = 2026,
                Mileage = 4600,
                FirstRegistration = new DateTime(2026, 1, 18),
                Vin = "POR26P00000001020",
                LicensePlate = "HH-PA 1020",
                Condition = CarCondition.Excellent,
                PreviousOwners = 0,
                Location = "Hamburg, Germany",

                TechnicalData = new CarTechnicalData
                {
                    PowerKw = 575,
                    TorqueNm = 1000,
                    Acceleration = 2.90m,
                    TopSpeedKmh = 325,
                    TransmissionType = CarTransmissionType.DualClutch,
                    DriveType = CarDriveType.AWD,
                    FuelType = CarFuelType.Petrol,
                    CurbWeightKg = 2365,
                    TrunkCapacityLiters = 421,
                    ExteriorColor = "Volcano Grey Metallic",
                    InteriorColor = "Black / Bordeaux Red",
                    PowerTrain = CarPowerTrain.PHEV,

                    EngineType = "4.0 l Twin-Turbo V8",
                    DisplacementCc = 3996,
                    Cylinders = 8,
                    BatteryType = "Lithium-Ion",
                    BatteryCapacityKwh = 25.9m,
                    UsableBatteryCapacityKwh = 21.8m,
                    ElectricRangeKm = 88,
                    FuelTankCapacityLiters = 80,
                    FuelConsumption = 1.5m,
                    EnergyConsumption = 23.4m,
                    Co2Emissions = 34,
                    EmissionStandard = "Euro 6e"
                },

                CommercialData = new CarCommercialData
                {
                    CurrentValue = 229500m,
                    PurchasePrice = 241000m,
                    PurchaseDate = new DateOnly(2025, 12, 28),
                    Dealer = "Porsche Zentrum Hamburg",
                    InvoiceNo = "PZH-2025-12280",
                    WarrantyUntil = new DateOnly(2028, 12, 28),
                    AnnualInsuranceCost = 3600m,
                    AnnualRoadTax = 190m,
                    AnnualFuelCost = 1650m,
                    AnnualMaintenanceCost = 2850m
                },

                TimelineItems = new List<CarTimelineItem>
                {
                    new()
                    {
                        Date = new DateOnly(2025, 12, 28),
                        Title = "Vehicle purchased",
                        Description = "Purchased from Porsche Zentrum Hamburg.",
                        IsCompleted = true
                    },
                    new()
                    {
                        Date = new DateOnly(2026, 1, 18),
                        Title = "First registration",
                        Description = "Vehicle registered in Hamburg.",
                        IsCompleted = true
                    },
                    new()
                    {
                        Date = new DateOnly(2026, 5, 12),
                        Title = "Hybrid system inspection",
                        Description = "High-voltage system inspected successfully.",
                        IsCompleted = true
                    },
                    new()
                    {
                        Date = new DateOnly(2026, 12, 18),
                        Title = "Next service",
                        Description = "Scheduled maintenance and software check.",
                        IsCompleted = false
                    }
                }
            };
        }
    }
}
