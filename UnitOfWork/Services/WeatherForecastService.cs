using Microsoft.EntityFrameworkCore;
using UnitOfWork.Data;
using UnitOfWork.Models;
using UnitOfWork.Interfaces;
using AutoMapper;

namespace UnitOfWork.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly DataContext _context;

        private readonly IMapper _mapper;

        public WeatherForecastService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<WeatherForecast>> GetWeatherForecastAsync()
        {
            var result = await _context.WeatherForecasts.ToListAsync();

            //This is how you return WeatherForecasts without using AutoMapper

            //List<WeatherForecast> list = new List<WeatherForecast>();

            //foreach (var item in result)
            //{
            //    list.Add(new WeatherForecast()
            //    {
            //        Date = item.Date,
            //        TemperatureC = item.TemperatureC,
            //        Summary = item.Summary
            //    });
            //}
            //return list;

            return _mapper.Map<List<Models.WeatherForecast>>(result);
        }
        public async Task<WeatherForecast> GetForecastByIdAsync(int id)
        {
            var result = await _context.WeatherForecasts.FindAsync(id);

            return _mapper.Map<Models.WeatherForecast>(result);
        }

    }
}
