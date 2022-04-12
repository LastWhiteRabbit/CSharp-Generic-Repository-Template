using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UnitOfWork.Data;
using UnitOfWork.Models;
using UnitOfWork.Interfaces;
using UnitOfWork.SearchObject;
using UnitOfWork.Requests;

namespace UnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController
        : BaseCRUDController<Models.WeatherForecast, WeatherForecastSearchObject, WeatherForecastInsertRequest, WeatherForecastUpdateRequest>
    {
        public WeatherForecastController(IWeatherForecastService service)
            : base(service)
        {
        }
    }
}
