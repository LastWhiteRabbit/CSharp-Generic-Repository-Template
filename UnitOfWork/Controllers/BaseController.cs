using Microsoft.AspNetCore.Mvc;
using UnitOfWork.Interfaces;

namespace UnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T, TSearch> : ControllerBase where T : class where TSearch : class
    {
        public IService<T, TSearch> _service { get; set; }
        public BaseController(IService<T, TSearch> service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<IEnumerable<T>> Get([FromQuery]TSearch? search = null)
        {
            return await _service.GetAsync(search);
        }

        [HttpGet("{id}")]
        public async Task<T> GetById(int id)
        {
            return await _service.GetByIdAsync(id);
        }

    }
}
