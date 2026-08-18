using System.ComponentModel.DataAnnotations;

namespace CarManager.Core.Enums
{
    public enum CarStatus
    {
        [Display(Name = "Available")]
        Available,
        [Display(Name = "In Use")]
        InUse,
        [Display(Name = "Reserved")]
        Reserved,
        [Display(Name = "Maintenance")]
        Maintenance,
        [Display(Name = "Sold")]
        Sold
    }

    public enum CarBodyType
    {
        Coupe,
        Convertible,
        Sedan,
        Suv,
        Wagon,
        Hatchback
    }

    public enum CarCondition
    {
        New,
        Excellent,
        Good,
        Fair
    }

    public enum CarDriveType
    {
        FWD,
        RWD,
        AWD
    }

    public enum CarFuelType
    {
        Petrol,
        Diesel,
        Hydrogen
    }

    public enum CarPowerTrain
    {
        ICE,
        MHEV,
        HEV,
        PHEV,
        BEV,
        FCEV
    }

    public enum CarTransmissionType
    {
        [Display(Name = "Manual")]
        Manual,
        [Display(Name = "Automatic")]
        Automatic,
        [Display(Name = "Dual Clutch")]
        DualClutch,
        [Display(Name = "CVT")]
        CVT,
        [Display(Name = "Single Speed")]
        SingleSpeed
    }
}
