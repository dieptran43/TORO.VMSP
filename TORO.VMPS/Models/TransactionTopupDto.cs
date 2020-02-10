using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TORO.VMPS.Models
{
    /// <summary>
    /// Danh sách topup dùng chung cho phần đồng bộ nhiều giao dịch
    /// </summary>
    public class TransactionTopupDto
    {
        public TransactionTopupDto()
        {
            CashInfos = new List<CashInfoDto>();
        }

        /// <summary>
        /// VM tạo ra
        /// </summary>
        public string TransactionCode { get; set; }

        /// <summary>
        /// Số tiền Topup
        /// </summary>
        public float Amount { get; set; }

        public string TransactNote { get; set; }

        public int CompanyId { get; set; }

        public string MachineCode { get; set; }

        /// <summary>
        /// Thời gian giao dịch khi hoàn tất việc đưa tiền vào và nhấn xác nhận(local VM)
        /// </summary>
        public DateTime TopupTime { get; set; }

        /// <summary>
        /// Thời gian gửi lên server (local VM): Lúc nạp tiền xong hoặc lúc đồng bộ
        /// </summary>
        public DateTime SyncTime { get; set; }

        public List<CashInfoDto> CashInfos { get; set; }
    }
}
