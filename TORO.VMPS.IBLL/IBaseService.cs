using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TORO.VMPS.IBLL
{
    public interface IBaseService<TEntity, TDto>
        where TEntity : class
        where TDto : class
    {
        Task<TDto> CreateAsync(TDto dto);

        Task<TDto> UpdateAsync(TDto dto);

        Task DeleteAsync(object keyValues);

        //Task DeleteAsync(TDto obj);

        Task<TDto> FindByIdAsync(object keyValues);

        Task<IQueryable<TEntity>> SearchAsync(Expression<Func<TEntity, bool>> predicate);

        Task<IQueryable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
    }
}
