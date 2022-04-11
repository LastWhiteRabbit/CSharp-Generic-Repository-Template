using UnitOfWork.Models;

namespace UnitOfWork.Interfaces
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecast>> GetWeatherForecastAsync();

        Task<WeatherForecast> GetForecastByIdAsync(int id);
    }
}
