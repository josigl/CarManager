using Microsoft.EntityFrameworkCore;
using CarManager.Core.Models;

namespace CarManager.Infrastructure.Data
{
    public class CarManagerDbContext : DbContext
    {
        public DbSet<Car> Cars => Set<Car>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                  @"Server=localhost\SQLEXPRESS;
                  Database=CarManager;
                  Trusted_Connection=True;
                  TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CarManagerDbContext).Assembly);
        }

    }
}
