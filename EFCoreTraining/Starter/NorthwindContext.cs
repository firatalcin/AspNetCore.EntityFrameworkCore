using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Starter.Model;

namespace Starter
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConfigurationManager configuration = new();
            configuration.AddJsonFile("appsettings.json");
            optionsBuilder.UseSqlServer($"Server=localhost, 1433;Database=Northwind;User Id=sa;Password={configuration["Password"]}");
        }
    }
}
