using CarManager.Core.Models;

namespace CarManager.Core.Repositories
{
    public interface ICarRepository
    {
        Task<Car?> GetByIdAsync(int id);
    }
}
