using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TORO.VMPS.DAL.Entities
{
    public class OrderDetails
    {
        public int Id { get; set; }
        [MaxLength(10)] // just for demonstrating transaction failure
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
