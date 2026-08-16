using CarManager.Core.Enums;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarManager.WPF.ViewModels.CarDetails
{
    public class GeneralTabViewModel : ObservableObject
    {
        public GeneralTabViewModel()
        {
            Make = "Porsche";
            Model = "911 (992)";
            Variant = "GT3 RS";
            BodyType = "Coupe";
            ModelYear = 2026;
            FirstRegistration = new DateTime(2026, 5, 1);

            Id = 1001;
            Vin = "WP0ZZZ99ZTS390417";
            LicensePlate = "HH-JS 911";

            Condition = "Used";
            Status = CarStatus.Available;
            PreviousOwners = 1;
            Location = "Hamburg, Germany";
        }

        public string Make { get; }
        public string Model { get; }
        public string Variant { get; }
        public string BodyType { get; }
        public int ModelYear { get; }
        public DateTime FirstRegistration { get; }

        public int Id { get; }
        public string Vin { get; }
        public string LicensePlate { get; }

        public string Condition { get; }
        public CarStatus Status { get; }
        public int PreviousOwners { get; }
        public string Location { get; }

    }
}
