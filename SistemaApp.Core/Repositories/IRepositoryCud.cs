namespace SistemaApp.Core.Repositories
{
    public interface IRepositoryCud<T> where T : class
    {
        public void Create(T model);
        public int Update(T model);
        public void DeleteAsync(int id);
        public void Delete(T model);
    }
}
