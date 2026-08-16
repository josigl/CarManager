using System;
using System.Collections.Generic;
using System.Text;

namespace CarManager.WPF.Factories
{
    public interface ICarDetailsWindowFactory
    {
        Task ShowExistingAsync(int carId);

        Task ShowNewAsync();
    }
}
