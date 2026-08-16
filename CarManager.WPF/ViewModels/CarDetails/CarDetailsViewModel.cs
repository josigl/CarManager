using CarManager.Core.Enums;
using CarManager.Core.Models;
using CarManager.Core.Services;
using CarManager.Core.Utilities;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CarManager.WPF.ViewModels.CarDetails
{
    public partial class CarDetailsViewModel : ObservableObject
    {
        private readonly ICarService? _carService;

        protected CarDetailsViewModel() : this(null) { }

        public CarDetailsViewModel(ICarService? carService)
        {
            _carService = carService;

            GeneralTab = new GeneralTabViewModel();
            TechnicalTab = new TechnicalTabViewModel();
            CommercialTab = new CommercialTabViewModel();
        }

        [ObservableProperty]
        public partial bool IsLoading { get; private set; } = true;

        [ObservableProperty]
        public partial int Id { get; protected set; }

        [ObservableProperty]
        public partial CarStatus Status { get; protected set; }

        [ObservableProperty]
        public partial string Make { get; protected set; } = string.Empty;

        [ObservableProperty]
        public partial string Model { get; protected set; } = string.Empty;

        [ObservableProperty]
        public partial string? Variant { get; protected set; } = string.Empty;

        [ObservableProperty]
        public partial int Mileage { get; protected set; }

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(PowerHp))]
        public partial int PowerKw { get; protected set; }

        public int PowerHp => UnitConverter.KwToHp(PowerKw);

        [ObservableProperty]
        public partial string FuelType { get; protected set; } = string.Empty;
        
        [ObservableProperty]
        public partial string Transmission { get; protected set; } = string.Empty;

        [ObservableProperty]
        public partial DateTime FirstRegistration { get; protected set; }

        [ObservableProperty]
        public partial decimal CurrentValue { get; protected set; }

        public GeneralTabViewModel GeneralTab { get; init; }
        public TechnicalTabViewModel TechnicalTab { get; init; }
        public CommercialTabViewModel CommercialTab { get; init; }

        public async Task InitializeFromExistingAsync(int carId)
        {
            if (_carService is null)
                throw new InvalidOperationException(
                    "Car service is not available in design mode.");

            IsLoading = true;

            try
            {
                Car? car = await _carService.GetByIdAsync(carId);

                if (car is null)
                    return;

                Id = car.Id;
                Status = car.Status;
                Make = car.Make;
                Model = car.Model;
                Variant = car.Variant;

                Mileage = car.Mileage;
                PowerKw = car.TechnicalData.PowerKw;
                FuelType = car.TechnicalData.FuelType.ToString() ?? string.Empty;
                Transmission = car.TechnicalData.TransmissionType.ToString() ?? string.Empty;
                FirstRegistration = car.FirstRegistration;
                CurrentValue = car.CommercialData.CurrentValue;
            }
            finally
            {
                IsLoading = false;
            }
        }

        public void InitializeNew()
        {
            Make = string.Empty;
            Model = string.Empty;

            // Set valid defaults ...
            // When saving ...
            // var car = new Car { Make = Make, Model = Model etc. };

        }

    }
}
