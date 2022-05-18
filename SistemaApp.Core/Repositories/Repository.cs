using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Data;

namespace SistemaApp.Core.Repositories
{
    public class Repository<T> : IRepository<T> 
        where T : class
    {
        private readonly SistemaAppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(SistemaAppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public virtual void Create(T model)
            => _dbSet.Add(model);


        public virtual IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual T? GetById(int id)
        {
            throw new NotImplementedException();
        }
        public virtual async Task<IEnumerable<T>> GetPaginated(int pageSize, int pageNumber)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(T model)
        {
            _dbSet.Attach(model);
            _context.Entry(model).State = EntityState.Modified;
        }

        public virtual void Delete(int id)
        {
            var deleteModel = _dbSet.Find(id);
            Delete(deleteModel);
        }

        public virtual void Delete(T model)
        {
            if(_context.Entry(model).State == EntityState.Detached)
            {
                _dbSet.Attach(model);
            }
            _dbSet.Remove(model);
        }
    }
}
