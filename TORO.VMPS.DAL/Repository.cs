using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TORO.VMPS.DAL.DbContexts;
using TORO.VMPS.IDAL;

namespace TORO.VMPS.DAL
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

        public virtual void Delete(TEntity entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void InsertFreshContext(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual IQueryable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query = _dbSet;
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            return query;
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
