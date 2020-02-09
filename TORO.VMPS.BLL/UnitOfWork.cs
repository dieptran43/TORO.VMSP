using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TORO.VMPS.DAL.DbContexts;
using TORO.VMPS.DAL.Entities;
using TORO.VMPS.IBLL;

namespace TORO.VMPS.BLL
{
    public class UnitOfWork: IUnitOfWork
    {
        private CourseLibraryContext _context;
        private bool _disposed = false;
        public IRepository<Course> CourseLibraryRepository { get; private set; }
        public IRepository<Order> OrderRepository { get; private set; }
        public IRepository<OrderDetails> OrderDetailsRepository { get; private set; }

        private void InitRepositories()
        {
            CourseLibraryRepository = new Repository<Course>(_context);
            OrderRepository = new Repository<Order>(_context);
            OrderDetailsRepository = new Repository<OrderDetails>(_context);
        }

        public UnitOfWork(CourseLibraryContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            InitRepositories();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
            //using var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
            //{
            //    await _context.SaveChangesAsync();
            //    scope.Complete();
            //}
        }
    }
}