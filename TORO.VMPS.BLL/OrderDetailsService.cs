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
    public class OrderDetailsService : BaseService<OrderDetails, OrderDetailsDto>, IOrderDetailsService
    {
        private readonly IMapper _mapper;
        public OrderDetailsService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _mapper = mapper;
        }
        protected override IRepository<OrderDetails> _reponsitory => _unitOfWork.OrderDetailsRepository;

        public async Task SubmitAsync(string createBy, IEnumerable<OrderDetailsDto> orderDetails)
        {
            var orderDto = new OrderDto
            {
                CreatedAt = DateTime.Now,
                CreatedBy = createBy,
                Sku = Guid.NewGuid().ToString("n").Substring(0, 6)
            };

            var orderEntity = _mapper.Map<Order>(orderDto);

            _unitOfWork.OrderRepository.Add(orderEntity);

            foreach (var details in orderDetails)
            {
                details.Order = orderEntity;
                details.CreatedAt = DateTime.Now;
                _unitOfWork.OrderDetailsRepository.Add(DtoToEntity(details));
            }
            await _unitOfWork.SaveAsync();
        }
    }
}
