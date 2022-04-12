using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UnitOfWork.Data;
using UnitOfWork.Interfaces;
using UnitOfWork.SearchObject;

namespace UnitOfWork.Services
{
    public class BaseService<T, TDb, TSearch> : IService<T, TSearch> where T : class where TDb : class where TSearch : BaseSearchObject
    {
        public DataContext _context { get; set; }
        public IMapper _mapper { get; set; }

        public BaseService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = _context.Set<TDb>();

            var result = await entity.FindAsync(id);

            return _mapper.Map<T>(result);
        }

        public async Task<IEnumerable<T>> GetAsync(TSearch search = null)
        {
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

            var entity = _context.Set<TDb>().AsQueryable();

            entity = AddFilter(entity, search);

            if(search?.Page.HasValue == true && search?.PageSize.HasValue == true)
            {
                entity = entity.Take(search.PageSize.Value).Skip(search.Page.Value * search.PageSize.Value);
            }

            var list = await entity.ToListAsync();

            return _mapper.Map<IEnumerable<T>>(list);
        }

        public virtual IQueryable<TDb> AddFilter(IQueryable<TDb> query, TSearch search = null)
        {
            return query;
        }
    }
}
