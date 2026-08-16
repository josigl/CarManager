using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarManager.Infrastructure.Data
{
    public class CarManagerDbContextFactory : IDesignTimeDbContextFactory<CarManagerDbContext>
    {
        public CarManagerDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CarManagerDbContext>();

            optionsBuilder.UseSqlServer(
                @"Server=localhost\SQLEXPRESS;
                  Database=CarManager;
                  Trusted_Connection=True;
                  TrustServerCertificate=True;");

            return new CarManagerDbContext(optionsBuilder.Options);
        }
    }
}
