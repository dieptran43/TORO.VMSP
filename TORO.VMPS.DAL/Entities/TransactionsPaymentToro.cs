﻿using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace TORO.VMPS.DAL.Entities
{
    public class TransactionsPaymentToro
    {
        [Key]
        public long TransactionId { get; set; }
    }
}