using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TORO.VMPS.DAL.Dtos;
using TORO.VMPS.DAL.Entities;

namespace TORO.VMPS.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            #region Enity To Dto

            CreateMap<Order, OrderDto>();
            CreateMap<OrderDetails, OrderDetailsDto>();

            #endregion

            #region Dto to Entity

            CreateMap<OrderDto, Order>();
            CreateMap<OrderDetailsDto, OrderDetails>();

            #endregion
        }
    }
}
