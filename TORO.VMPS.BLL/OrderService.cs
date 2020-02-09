using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TORO.VMPS.DAL.Dtos;
using TORO.VMPS.DAL.Entities;
using TORO.VMPS.IBLL;

namespace TORO.VMPS.BLL
{
    public class OrderService : BaseService<Order, OrderDto>, IOrderService
    {
        private readonly IMapper _mapper;
        public OrderService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _mapper = mapper;
        }
        protected override IRepository<Order> _reponsitory => _unitOfWork.OrderRepository;

        public async Task SubmitAsync(string createBy, IEnumerable<OrderDetailsDto> orderDetails)
        {
            var orderDto = new OrderDto
            {
                CreatedAt = DateTime.Now,
                CreatedBy = createBy,
                Sku = Guid.NewGuid().ToString("n").Substring(0, 6)
            };

            var orderEntity = DtoToEntity(orderDto);
            _unitOfWork.OrderRepository.Add(orderEntity);

            foreach (var details in orderDetails)
            {
                details.Order = orderEntity;
                var detailsEntity = _mapper.Map<OrderDetails>(details);
                _unitOfWork.OrderDetailsRepository.Add(detailsEntity);
            }
            await _unitOfWork.SaveAsync();
        }
    }
}
