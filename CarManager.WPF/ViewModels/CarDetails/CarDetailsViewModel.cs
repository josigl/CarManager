using CarManager.Core.Models;
using CarManager.Core.Services;
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
        }

        [ObservableProperty]
        public partial bool IsLoading { get; private set; } = true;

        [ObservableProperty]
        public partial Car? Car { get; protected set; }

        [ObservableProperty]
        public partial TechnicalTabViewModel? TechnicalTab { get; protected set; }
        
        [ObservableProperty]
        public partial CommercialTabViewModel? CommercialTab { get; protected set; }

        public async Task InitializeFromExistingAsync(int carId)
        {
            if (_carService is null)
                throw new InvalidOperationException(
                    "Car service is not available in design mode.");

            IsLoading = true;
            await Task.Delay(1500); // for testing purposes only

            try
            {
                Car = await _carService.GetByIdAsync(carId);

                if (Car is null)
                    return;

                TechnicalTab = new TechnicalTabViewModel(Car.TechnicalData);
                CommercialTab = new CommercialTabViewModel(Car.CommercialData, Car.TimelineItems);
            }
            finally
            {
                IsLoading = false;
            }
        }

    }
}