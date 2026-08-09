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
}
