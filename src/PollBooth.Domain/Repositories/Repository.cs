using System.Data.Entity;
using System.Linq;

namespace PollBooth.Domain.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public T Get(object id)
        {
            return _context.Set<T>().Find(id);
        }

        public TEntity Get<TEntity>(object id) where TEntity : class
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public IQueryable<TEntity> GetAll<TEntity>() where TEntity : class
        {
            return _context.Set<TEntity>();
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Insert<TEntity>(TEntity entity) where TEntity : class
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Update<TEntity>(TEntity entity) where TEntity : class
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Delete<TEntity>(TEntity entity) where TEntity : class
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public void Reload(T entity)
        {
            _context.Entry(entity).Reload();
        }

        public void Reload<TEntity>(TEntity entity) where TEntity : class
        {
            _context.Entry(entity).Reload();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}