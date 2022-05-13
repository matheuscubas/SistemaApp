namespace SistemaApp.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        public void Create(T model);

        public IEnumerable<T> GetAll();

        public T? GetById(int id);
        public IEnumerable<T> GetPaginated();

        public void Update(T model);

        public void Delete(int id);
        public void Delete(T model);
    }
}
