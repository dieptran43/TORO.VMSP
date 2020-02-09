using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TORO.VMPS.DAL.DbContexts;
using TORO.VMPS.IBLL;

namespace TORO.VMPS.BLL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal CourseLibraryContext _context;
        internal DbSet<TEntity> _dbSet;
        public Repository(CourseLibraryContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            _dbSet.Add(obj);
        }

        public virtual void Update(TEntity obj)
        {
            _dbSet.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public virtual void Delete(object id)
        {
            TEntity ent = _dbSet.Find(id);
            Delete(ent);
        }

        public virtual void Delete(TEntity obj)
        {
            if (_context.Entry(obj).State == EntityState.Detached)
            {
                _dbSet.Attach(obj);
            }
            _dbSet.Remove(obj);
        }

        public virtual async Task<TEntity> FindByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual IQueryable<TEntity> Search(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query = _dbSet;
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            return query;
        }

        public virtual IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }
            return orderBy != null ? orderBy(query) : query;
        }
    }
}
