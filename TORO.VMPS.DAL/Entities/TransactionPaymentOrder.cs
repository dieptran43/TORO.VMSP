using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace TORO.VMPS.DAL.Entities
{
    public class TransactionPaymentOrder
    {
        public long TransactionsPaymentId { get; set; }

        [MaxLength(50)]
        public string BillNumber { get; set; }

        [MaxLength(50)]
        /// <summary>
        /// Cash/Momo/Toro/Grab
        /// </summary>
        public string ParnerTransactionCode { get; set; }

        public int CompanyId { get; set; }

        [MaxLength(50)]
        public string StoreId { get; set; }

        [MaxLength(50)]
        public string MachineCode { get; set; }

        /// <summary>
        /// Số tiền đơn hàng thời điểm đặt hàng
        /// </summary>
        public float OrderAmount { get; set; }

        /// <summary>
        /// Số tiền khuyến mãi thời điểm đặt hàng
        /// </summary>
        public float OrderPromoAmount { get; set; }

        /// <summary>
        /// Số tiền đơn hàng (đã trừ đi refund)
        /// </summary>
        public float Amount { get; set; }

        /// <summary>
        /// Số tiền khuyến mãi (đã trừ đi refund)
        /// </summary>
        public float PromoAmount { get; set; }

        [MaxLength(50)]
        /// <summary>
        /// NEW/PENDING/SUCCESS/FAIL
        /// </summary>
        public string Status { get; set; }

        [MaxLength(50)]
        /// <summary>
        /// PAYMENT
        /// </summary>
        public string TransactionType { get; set; }

        /// <summary>
        /// 1 là BuyToro, 2 Buy Voucher, 3 By Cash, 4 Buy GrabPay, 5 Buy V-more, 6 Buy MoMo, ..
        /// </summary>
        public int PaymentType { get; set; }

        public string Note { get; set; }

        public DateTime SyncTime { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}