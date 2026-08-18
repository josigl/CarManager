using CarManager.WPF.ViewModels.CarDetails;
using CarManager.WPF.Views;
using Microsoft.Extensions.DependencyInjection;

namespace CarManager.WPF.Factories
{
    public class CarDetailsWindowFactory : ICarDetailsWindowFactory
    {
        private readonly IServiceScopeFactory _scopeFactory;

        public CarDetailsWindowFactory(IServiceScopeFactory serviceScopeFactory)
        {
            _scopeFactory = serviceScopeFactory;
        }

        public Task ShowExistingAsync(int carId) => ShowWindowWithNewOrExistingAsync(carId);

        public Task ShowNewAsync() => ShowWindowWithNewOrExistingAsync(null);

        private async Task ShowWindowWithNewOrExistingAsync(int? carId)
        {
            var scope = _scopeFactory.CreateScope();

            var viewModel = scope.ServiceProvider
                .GetRequiredService<CarDetailsViewModel>();

            var window = new CarDetailsWindow(viewModel);

            window.Closed += (_, _) => scope.Dispose();

            window.Show();

            if (carId is not null)
                await viewModel.InitializeFromExistingAsync(carId.Value);
        }
    }
}
