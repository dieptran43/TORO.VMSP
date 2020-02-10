using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TORO.VMPS.Models
{
    /// <summary>
    /// Danh sách topup dùng chung cho phần đồng bộ nhiều giao dịch
    /// </summary>
    public class TopupDto
    {
        /// <summary>
        /// VM tạo ra
        /// </summary>
        public string BillNumber { get; set; }

        /// <summary>
        /// Số tiền thanh toán
        /// </summary>
        public float Amount { get; set; }

        /// <summary>
        /// Số tiền khuyến mãi
        /// </summary>
        public float PromoAmount { get; set; }

        public int CompanyId { get; set; }

        public string StoreId { get; set; }

        /// <summary>
        /// Terminal Id
        /// </summary>
        public string MachineCode { get; set; }

        /// <summary>
        /// 1 là BuyToro, 2 Buy Voucher, 3 By Cash, 4 Buy GrabPay, 5 Buy V-more, 6 Buy MoMo, ...
        /// </summary>
        public string PaymentType { get; set; }
    }
}