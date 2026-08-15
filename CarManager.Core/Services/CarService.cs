using CarManager.Core.Models;
using CarManager.Core.Repositories;

namespace CarManager.Core.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public Task<Car?> GetByIdAsync(int id) => _carRepository.GetByIdAsync(id);
    }
}
