using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Common.Repositories
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        IQueryable<TEntity> GetQueryable();
        IQueryable<TEntity> GetQueryable(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetByIdAsync(int id);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includes);
        void Add(TEntity entity);
        Task AddRange(List<TEntity> entities);
        void Update(TEntity entity);
        void DetectUpdate(TEntity entity);
        void Delete(TEntity entity);
        Task DeleteAsync(int id);
        Task SaveAsync();

    }
}
