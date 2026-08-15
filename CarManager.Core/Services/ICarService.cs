using CarManager.Core.Models;

namespace CarManager.Core.Services
{
    public interface ICarService
    {
        Task<Car?> GetByIdAsync(int id);

    }
}