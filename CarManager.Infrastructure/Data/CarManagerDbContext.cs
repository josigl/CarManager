using Microsoft.EntityFrameworkCore;
using CarManager.Core.Models;

namespace CarManager.Infrastructure.Data
{
    public class CarManagerDbContext : DbContext
    {
        // Context gets its EF-config through DI/Host --> App.xaml.cs
        public CarManagerDbContext(DbContextOptions<CarManagerDbContext> options) : base(options) { }

        public DbSet<Car> Cars => Set<Car>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CarManagerDbContext).Assembly);
        }

    }
}
