using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TORO.VMPS.DAL.Dtos;
using TORO.VMPS.DAL.Entities;

namespace TORO.VMPS.BLL.AutoMapper
{
    public class DtoEntityCommonMapper: Profile
    {
        public DtoEntityCommonMapper()
        {
            ////#region Enity To Dto

            //CreateMap<Order, OrderDto>();
            //CreateMap<OrderDetails, OrderDetailsDto>();

            ////#endregion

            ////#region Dto to Entity

            //CreateMap<OrderDto, Order>();
            //CreateMap<OrderDetailsDto, OrderDetails>();

            ////#endregion
        }
    }
}
