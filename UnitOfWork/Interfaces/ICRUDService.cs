namespace UnitOfWork.Interfaces
{
    public interface ICRUDService<T, TSearch, TInsert, TUpdate> : IService<T,TSearch>
        where T : class where TSearch : class where TInsert : class where TUpdate : class
    {
        Task<T> InsertAsync(TInsert insert);

        Task<T> UpdateAsync(int id, TUpdate update);
    }
}
