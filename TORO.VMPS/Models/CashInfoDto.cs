using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TORO.VMPS.Models
{
    public class CashInfoDto
    {
        public CashInfoDto()
        {
            CashDetails = new List<CashDetailListDto>();
        }

        /// <summary>
        /// Mã giao dịch
        /// </summary>
        public string TransactionCode { get; set; }

        /// <summary>
        /// Tổng tiền cash nạp vào để thanh toán
        /// </summary>
        public float PaymentAmount { get; set; }

        /// <summary>
        /// Thông tin tài khoản
        /// </summary>
        public string AccountInfo { get; set; }

        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string PhoneNumber { get; set; }

        public List<CashDetailListDto> CashDetails { get; set; }
    }
}