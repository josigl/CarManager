using System;
using System.Collections.Generic;
using System.Text;
using CarManager.Core.Enums;
using CarManager.Core.Utilities;

namespace CarManager.UI.ViewModels.CarDetails
{
    public class CarDetailsViewModel : BaseViewModel
    {
        public CarDetailsViewModel()
        {
            Id = 1001;
            Status = CarStatus.Available;
            Make = "Porsche";
            Model = "911 (992)";
            Variant = "GT3 RS";

            Mileage = 1235;
            PowerKw = 386;
            FuelType = "Petrol";
            Transmission = "Automatic";
            FirstRegistration = new DateTime(2026, 5, 1);
            CurrentValue = 329_990;

            GeneralTab = new GeneralTabViewModel();
            TechnicalTab = new TechnicalTabViewModel();
            CommercialTab = new CommercialTabViewModel();
        }

        public int Id { get; }
        public CarStatus Status { get; }

        public string Make { get;  }
        public string Model { get; }
        public string Variant { get; }

        public int Mileage { get; } 
        public int PowerKw { get; }
        public int PowerHp => UnitConverter.KwToHp(PowerKw);
        public string FuelType { get; }
        public string Transmission { get; }
        public DateTime FirstRegistration { get; }
        public decimal CurrentValue { get; }

        public GeneralTabViewModel GeneralTab { get; init; }
        public TechnicalTabViewModel TechnicalTab { get; init; }
        public CommercialTabViewModel CommercialTab { get; init; }

    }
}
