using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TORO.VMPS.DAL.Entities;

namespace TORO.VMPS.IBLL
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Course> CourseLibraryRepository { get; }
        IRepository<Order> OrderRepository { get; }
        IRepository<OrderDetails> OrderDetailsRepository { get; }
        Task SaveAsync();
    }
}
