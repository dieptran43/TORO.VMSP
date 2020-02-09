using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TORO.VMPS.DAL.Dtos;
using TORO.VMPS.DAL.Entities;

namespace TORO.VMPS.IBLL
{
    public interface IOrderService : IBaseService<Order, OrderDto>
    {
        Task SubmitAsync(string createBy, IEnumerable<OrderDetailsDto> orderDetails);
    }
}
