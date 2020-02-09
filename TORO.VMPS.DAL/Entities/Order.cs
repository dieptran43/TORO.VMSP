using System;
using System.Collections.Generic;
using System.Text;

namespace TORO.VMPS.DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
