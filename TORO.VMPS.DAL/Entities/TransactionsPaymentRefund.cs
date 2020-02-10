using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TORO.VMPS.DAL.Entities
{
    public class TransactionsPaymentRefund
    {
        [Key]
        public long TransactionsPaymentRefundId { get; set; }

        public long TransactionsPaymentId { get; set; }

        /// <summary>
        /// Số tiền refund
        /// </summary>
        public float Amount { get; set; }

        /// <summary>
        /// Nguyên nhân refund
        /// </summary>
        public string ReasonType { get; set; }

        public string Note { get; set; }

        [MaxLength(50)]
        /// <summary>
        /// NEW/PENDING/SUCCESS/FAIL
        /// </summary>
        public string Status { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        [MaxLength(200)]
        public string CreateBy { get; set; }

        [MaxLength(200)]
        public string UpdateBy { get; set; }
    }
}