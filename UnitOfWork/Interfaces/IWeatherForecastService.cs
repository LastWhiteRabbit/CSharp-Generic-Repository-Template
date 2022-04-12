using UnitOfWork.Models;
using UnitOfWork.SearchObject;

namespace UnitOfWork.Interfaces
{
    public interface IWeatherForecastService : IService<WeatherForecast, WeatherForecastSearchObject>
    {

    }
}
