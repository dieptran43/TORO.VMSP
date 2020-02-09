using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TORO.VMPS.DAL.Dtos;
using TORO.VMPS.IBLL;

namespace TORO.VMPS.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrderDetaisController : ControllerBase
    {
        private readonly IOrderDetailsService _orderDetailsService;
        public OrderDetaisController(IOrderDetailsService orderDetailsService)
        {
            _orderDetailsService = orderDetailsService;
        }

        [HttpPost]
        [Route("{createBy}")]
        public async Task Post(string createBy, [FromBody] IDictionary<string, IEnumerable<OrderDetailsDto>> dic)
        {
            //var orderDetailsList = dic["orderDetails"];
            var orderDetailsList = dic["additionalProp1"];
            await _orderDetailsService.SubmitAsync(createBy, orderDetailsList);
        }
    }
}
