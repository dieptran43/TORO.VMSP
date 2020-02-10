using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace TORO.VMPS.DAL.Entities
{
    public class TransactionCash
    {
        public long CashTransactionId { get; set; }

        public string TransactionCode { get; set; }

        [MaxLength(50)]
        public string CompanyId { get; set; }

        [MaxLength(50)]
        public string StoreId { get; set; }

        [MaxLength(50)]
        public string MachineCode { get; set; }

        /// <summary>
        /// Số tiền Bill
        /// </summary>
        public float Amount { get; set; }

        [MaxLength(50)]
        public string BillNumber { get; set; }

        public DateTime TransactionTime { get; set; }

        [MaxLength(50)]
        /// <summary>
        /// PAYMENT_ORDER: Số tiền của đơn hàng
        /// TOPUP_TORO: Số tiền Topup
        /// </summary>
        public string TransactionType { get; set; }

        [MaxLength(50)]
        /// <summary>
        /// Thông tin tài khoản
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Số tiền đưa vào
        /// </summary>
        public float CashAmount { get; set; }

        public DateTime SyncTime { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}