using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UnitOfWork.Data;
using UnitOfWork.Models;
using UnitOfWork.Interfaces;
using UnitOfWork.SearchObject;

namespace UnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController
        : BaseController<Models.WeatherForecast, WeatherForecastSearchObject>
    {
        public WeatherForecastController(IWeatherForecastService service)
            : base(service)
        {
        }
    }
}
