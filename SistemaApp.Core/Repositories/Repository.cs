using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Data;

namespace SistemaApp.Core.Repositories
{
    public class Repository<T> : IRepository<T> 
        where T : class
    {
        private readonly SistemaAppDbContext _context;
        private readonly DbSet<T> _dbset;

        public Repository(SistemaAppDbContext context)
        {
            _context = context;
            _dbset = context.Set<T>();
        }

        public void Create(T model)
            => _context.Add(model);


        public IEnumerable<T> GetAll()
            => _dbset.ToList();

        public T GetById(int id)
            => _dbset.Find(id);


        public void Update(T model)
        {
            _dbset.Attach(model);
            _context.Entry(model).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var deleteModel = _dbset.Find(id);
            Delete(deleteModel);
        }

        public void Delete(T model)
        {
            if(_context.Entry(model).State == EntityState.Detached)
            {
                _dbset.Attach(model);
            }
            _dbset.Remove(model);
        }
    }
}
