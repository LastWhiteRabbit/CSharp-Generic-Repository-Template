using UnitOfWork.Models;
using UnitOfWork.Requests;
using UnitOfWork.SearchObject;

namespace UnitOfWork.Interfaces
{
    public interface IWeatherForecastService : ICRUDService<WeatherForecast, WeatherForecastSearchObject, WeatherForecastInsertRequest, WeatherForecastUpdateRequest>
    {

    }
}
