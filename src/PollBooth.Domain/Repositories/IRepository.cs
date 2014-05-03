using System.Linq;

namespace PollBooth.Domain.Repositories
{
    public interface IRepository<T> where T : class
    {
        T Get(object id);
        TEntity Get<TEntity>(object id) where TEntity : class;
        IQueryable<T> GetAll();
        IQueryable<TEntity> GetAll<TEntity>() where TEntity : class;
        void Insert(T entity);
        void Insert<TEntity>(TEntity entity) where TEntity : class;
        void Update(T entity);
        void Update<TEntity>(TEntity entity) where TEntity : class;
        void Delete(T entity);
        void Delete<TEntity>(TEntity entity) where TEntity : class;
        void Reload(T entity);
        void Reload<TEntity>(TEntity entity) where TEntity : class;
        void Save();
    }
}