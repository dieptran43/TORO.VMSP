using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TORO.VMPS.DAL.Entities;

namespace TORO.VMPS.DAL.Dtos
{
    public class OrderDetailsDto
    {
        public int Id { get; set; }
        [MaxLength(10)]
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
