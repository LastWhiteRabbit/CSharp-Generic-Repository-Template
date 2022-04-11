using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UnitOfWork.Data;
using UnitOfWork.Models;
using UnitOfWork.Interfaces;

namespace UnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _service;

        public WeatherForecastController(IWeatherForecastService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            return await _service.GetWeatherForecastAsync();
        }

        [HttpGet("{id}")]
        public async Task<WeatherForecast> GetById(int id)
        {
            return await _service.GetForecastByIdAsync(id);
        }

    }
}
