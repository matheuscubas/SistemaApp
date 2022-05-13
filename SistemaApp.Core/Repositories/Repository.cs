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

        public void Create(T model)
            => _dbSet.Add(model);


        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T? GetById(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<T> GetPaginated()
        {
            throw new NotImplementedException();
        }

        public void Update(T model)
        {
            _dbSet.Attach(model);
            _context.Entry(model).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var deleteModel = _dbSet.Find(id);
            Delete(deleteModel);
        }

        public void Delete(T model)
        {
            if(_context.Entry(model).State == EntityState.Detached)
            {
                _dbSet.Attach(model);
            }
            _dbSet.Remove(model);
        }
    }
}
