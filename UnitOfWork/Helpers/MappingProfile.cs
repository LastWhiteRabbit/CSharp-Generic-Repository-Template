using AutoMapper;
using UnitOfWork.Requests;

namespace UnitOfWork.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Entities.WeatherForecast, Models.WeatherForecast>();
            CreateMap<WeatherForecastInsertRequest, Entities.WeatherForecast>();
            CreateMap<WeatherForecastUpdateRequest, Entities.WeatherForecast>();
        }
    }
}
