using CarManager.Core.Enums;
using CarManager.Core.Utilities;
using CarManager.WPF.ViewModels.CarDetails;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarManager.WPF.ViewModels.Design
{
    public class CarDetailsDesignViewModel : CarDetailsViewModel
    {
        public CarDetailsDesignViewModel()
        {
            Id = 1001;
            Make = "Porsche";
            Model = "911(992)";
            Variant = "GT3 RS";

            Mileage = 1235;
            PowerKw = 386;
            FuelType = "Petrol";
            Transmission = "Automatic";
            FirstRegistration = new DateTime(2026, 5, 1);
            CurrentValue = 329_990;
        }

    }
}
