namespace ISS.Controllers.Interfaces
{
    public interface IControllerInterface<T>
    {
         T Add(T entity);

         List<T> GetAll();

         T GetById(string id);

         T Update(T entity);

         void Delete(string id);
    }
}