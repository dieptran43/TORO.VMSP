using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace TORO.VMPS.DAL.Entities
{
    public class TransactionTopup
    {
        public long TransactionsTopupId { get; set; }

        /// <summary>
        /// Donation account/ user account
        /// </summary>
        public string AccountToro { get; set; }

        /// <summary>
        /// Cash/Momo/Toro/Grab
        /// </summary>
        public string ParnerTransactionCode { get; set; }

        /// <summary>
        /// REDEEM_CASH: Mã giao dịch cash
        /// REDEEM_DONATION_CASH: Mã giao dịch cash
        /// REFUND_CASH: Mã giao dịch refund
        /// REFUND_DONATION_CASH: Mã giao dịch refund trong giao dịch payment
        /// TOPUP_CASH: Mã giao dịch cash
        /// TOPUP_DONATION_CASH: Mã giao dịch cash
        /// </summary>
        public string RefTransactionId { get; set; }

        /// <summary>
        /// Số tiền topup
        /// </summary>
        public float Amount { get; set; }

        [MaxLength(50)]
        /// <summary>
        /// REDEEM_CASH: Tiền thừa so với bill, user có nhập tài khoản
        /// DONATION_CASH: Tiền thừa so với bill, user ko nhập tài khoản
        /// TOPUP_CASH: Topup cash
        /// TOPUP_DONATION_CASH: Topup ko nhập thông tin
        /// REFUND_REDDEM_CASH: Refund tiền do rớt hàng ko đủ, user có nhập tài khoản
        /// REFUND_DONATION_CASH: Refund tiền do rớt hàng ko đủ, user không nhập tài khoản
        /// </summary>
        public string TopupType { get; set; }

        [MaxLength(200)]
        /// <summary>
        /// Toro
        /// </summary>
        public string Partner { get; set; }

        [MaxLength(50)]
        /// <summary>
        /// NEW/PENDING/SUCCESS/FAIL
        /// </summary>
        public string Status { get; set; }
    }
}