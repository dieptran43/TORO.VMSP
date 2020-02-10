using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace TORO.VMPS.DAL.Entities
{
    public class TransactionCashDetail
    {
        public long CashTransactionId { get; set; }

        public string CashTransactionCode { get; set; }

        /// <summary>
        /// Số thứ tự đưa tiền vào. Bắt đầu từ 1,2...
        /// </summary>
        public int Seq { get; set; }

        [MaxLength(50)]
        /// <summary>
        /// Mã giá trị tiền
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Giá trị tiền
        /// </summary>
        public float Value { get; set; }

        /// <summary>
        /// Thời gian đưa tiền vào máy nhận được
        /// </summary>
        public DateTime PaymentTime { get; set; }

        [MaxLength(50)]
        /// <summary>
        /// NEW/SUCCESS
        /// </summary>
        public string Status { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}