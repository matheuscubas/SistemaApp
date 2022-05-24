using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Data;

namespace SistemaApp.Core.Repositories
{
    public class RepositoryCud<T> : IRepositoryCud<T> 
        where T : class
    {
        protected readonly SistemaAppDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public RepositoryCud(SistemaAppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public virtual void Create(T model)
            => _dbSet.Add(model);

        public virtual void Update(T model)
        {
            _dbSet.Attach(model);
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public virtual void DeleteAsync(int id)
        {
            var deleteModel = _dbSet.Find(id);
            Delete(deleteModel);
            _context.SaveChanges();
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
