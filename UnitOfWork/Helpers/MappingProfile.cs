using AutoMapper;

namespace UnitOfWork.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Entities.WeatherForecast, Models.WeatherForecast>();
        }
    }
}
