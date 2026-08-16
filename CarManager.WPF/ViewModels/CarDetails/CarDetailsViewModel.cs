using CarManager.Core.Enums;
using CarManager.Core.Models;
using CarManager.Core.Services;
using CarManager.Core.Utilities;

namespace CarManager.WPF.ViewModels.CarDetails
{
    public class CarDetailsViewModel : BaseViewModel
    {
        private readonly ICarService? _carService;

        protected CarDetailsViewModel()
        {
            GeneralTab = new GeneralTabViewModel();
            TechnicalTab = new TechnicalTabViewModel();
            CommercialTab = new CommercialTabViewModel();
        }

        public CarDetailsViewModel(ICarService carService)
        {
            _carService = carService;

            GeneralTab = new GeneralTabViewModel();
            TechnicalTab = new TechnicalTabViewModel();
            CommercialTab = new CommercialTabViewModel();
        }

        public int Id { get; protected set; }
        public CarStatus Status { get; protected set; }

        public string Make { get; protected set; }
        public string Model { get; protected set; }
        public string? Variant { get; protected set; }

        public int Mileage { get; protected set; }
        public int PowerKw { get; protected set; }
        public int PowerHp => UnitConverter.KwToHp(PowerKw);
        public string FuelType { get; protected set; }
        public string Transmission { get; protected set; }
        public DateTime FirstRegistration { get; protected set; }
        public decimal CurrentValue { get; protected set; }

        public GeneralTabViewModel GeneralTab { get; init; }
        public TechnicalTabViewModel TechnicalTab { get; init; }
        public CommercialTabViewModel CommercialTab { get; init; }

        public async Task InitializeFromExistingAsync(int carId)
        {
            if (_carService is null)
                throw new InvalidOperationException(
                    "Car service is not available in design mode.");

            Car? car = await _carService.GetByIdAsync(carId);

            if (car is null)
                return;

            Id = car.Id;
            Status = car.Status;
            Make = car.Make;
            Model = car.Model;
            Variant = car.Variant;

            PowerKw = car.TechnicalData.PowerKw;
            FuelType = car.TechnicalData.FuelType.ToString();
            Transmission = car.TechnicalData.TransmissionType.ToString();
            FirstRegistration = car.FirstRegistration;
            CurrentValue = car.CommercialData.CurrentValue;
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
