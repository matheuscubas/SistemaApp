namespace SistemaApp.Core.Repositories
{
    public interface IRepositoryRead<T>
        where T : class
    {
        public IEnumerable<T> GetAll();
        public T? GetById(int id);
        public Task<PaginationResult<T>> GetPaginated(int pageSize, int pageNumber);
    }
}
