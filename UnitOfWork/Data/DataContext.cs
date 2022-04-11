using Microsoft.EntityFrameworkCore;
using UnitOfWork.Entities;

namespace UnitOfWork.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    }
}
