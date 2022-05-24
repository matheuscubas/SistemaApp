namespace SistemaApp.Core.Repositories
{
    public interface IRepositoryRead<T>
        where T : class
    {
        public  Task<IEnumerable<T>> GetAllAsync();
        public  Task<T?> GetById(int id);
        public  Task<PaginationResult<T>> GetPaginated(int pageSize, int pageNumber);
    }
}
