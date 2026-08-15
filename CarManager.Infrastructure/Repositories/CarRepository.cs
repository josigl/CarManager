using CarManager.Core.Models;
using CarManager.Core.Repositories;
using CarManager.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CarManager.Infrastructure.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarManagerDbContext _context;

        public CarRepository(CarManagerDbContext context)
        {
            _context = context;
        }

        public async Task<Car?> GetByIdAsync(int id)
        {
            return await _context.Cars
                .Include(x => x.TechnicalData)
                .Include(x => x.CommercialData)
                .Include(x => x.TimelineItems)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
