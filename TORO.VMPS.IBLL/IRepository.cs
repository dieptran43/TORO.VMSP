using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TORO.VMPS.IBLL
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Delete(Object id);
        void Delete(TEntity obj);
        Task<TEntity> FindByIdAsync(object id);
        IQueryable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
    }
}
