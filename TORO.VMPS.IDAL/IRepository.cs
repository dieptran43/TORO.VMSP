using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace TORO.VMPS.IDAL
{
    public interface IRepository<T> where T : class
    {
        T GetById(object id);

        void Insert(T entity);

        void InsertFreshContext(T entity);

        void Update(T entity);

        void Delete(T entity);

        IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);

        //List<T> ExecuteSQLQuery(string query, object[] parameters);
    }
}
