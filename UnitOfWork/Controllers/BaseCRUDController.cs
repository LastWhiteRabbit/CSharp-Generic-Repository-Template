using Microsoft.AspNetCore.Mvc;
using UnitOfWork.Interfaces;

namespace UnitOfWork.Controllers
{
    public class BaseCRUDController<T, TSearch, TInsert, TUpdate> : BaseController<T, TSearch>
        where T : class where TSearch : class where TInsert : class where TUpdate : class
    {
        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
        }

        [HttpPost]
        public async Task<T> Insert([FromBody]TInsert insert)
        {
            var result = await ((ICRUDService<T, TSearch, TInsert, TUpdate>)this._service).InsertAsync(insert);

            return result;
        }

        [HttpPut("{id}")]
        public async Task<T> Update(int id,[FromBody] TUpdate update)
        {
            var result = await ((ICRUDService<T, TSearch, TInsert, TUpdate>)this._service).UpdateAsync(id, update);

            return result;

        }
    }
}
