using Microsoft.EntityFrameworkCore;
using UnitOfWork.Data;
using UnitOfWork.Models;
using UnitOfWork.Interfaces;
using AutoMapper;
using UnitOfWork.SearchObject;
using UnitOfWork.Requests;

namespace UnitOfWork.Services
{
    public class WeatherForecastService :
        BaseCRUDService<Models.WeatherForecast, Entities.WeatherForecast, WeatherForecastSearchObject, WeatherForecastInsertRequest, WeatherForecastUpdateRequest>, IWeatherForecastService
    {
        public WeatherForecastService(DataContext context, IMapper mapper) : base(context,mapper)
        {
        }

        public override IQueryable<Entities.WeatherForecast> AddFilter(IQueryable<Entities.WeatherForecast> query, WeatherForecastSearchObject? search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search?.TemperatureC != null)
            {
                filteredQuery = filteredQuery.Where(x => x.TemperatureC == search.TemperatureC);
            }

            return filteredQuery;
        }

    }
}
