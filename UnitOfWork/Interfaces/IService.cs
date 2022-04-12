namespace UnitOfWork.Interfaces
{
    public interface IService<T, TSearch> where T : class where TSearch : class
    {
        Task<IEnumerable<T>> GetAsync(TSearch? search = null);

        Task<T> GetByIdAsync(int id);
    }
}
