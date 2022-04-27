namespace ISS.Repositories.Interfaces
{
    public interface ICrudRepository<T>
    {
        Task<T> SelectById(Guid id);
        Task<List<T>> SelectAll();
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
        Task  Detele(Guid id);
    }
}