using System;
using System.Collections.Generic;
using System.Text;
using TORO.VMPS.DAL.Entities;

namespace TORO.VMPS.DAL.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
