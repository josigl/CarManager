using CarManager.Core.Repositories;
using CarManager.Core.Services;
using CarManager.Infrastructure.Data;
using CarManager.Infrastructure.Repositories;
using CarManager.WPF.Factories;
using CarManager.WPF.ViewModels.CarDetails;
using CarManager.WPF.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace CarManager.WPF
{
    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            var builder = Host.CreateApplicationBuilder();

            var connectionString = builder.Configuration.GetConnectionString("CarManager")
                                    ?? throw new InvalidOperationException(
                                        "Connection string 'CarManager' was not found.");

            /// Note:
            /// .AddScoped<T> uses one (same) instance within that scope
            /// WPF does not manage scopes by itself such as ASP.Net
            /// Hence scopes must be actively defined / declared 

            // DbContext is registred as "Scoped" by default
            builder.Services.AddDbContext<CarManagerDbContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddScoped<ICarRepository, CarRepository>();
            builder.Services.AddScoped<ICarService, CarService>();

            builder.Services.AddTransient<CarDetailsViewModel>();
            builder.Services.AddTransient<ICarDetailsWindowFactory, CarDetailsWindowFactory>();

            // Builds the host including the root DI service provider
            _host = builder.Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await _host.StartAsync();

            // Getting factory from DI container
            var factory = _host.Services.GetRequiredService<ICarDetailsWindowFactory>();

            await factory.ShowExistingAsync(1004);

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await _host.StopAsync();
            _host.Dispose();

            base.OnExit(e);
        }
    }

}
