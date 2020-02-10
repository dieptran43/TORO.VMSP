using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TORO.VMPS.Models
{
    public class CashDetailListDto
    {
        /// <summary>
        /// Thứ tự số tiền đưa vào
        /// </summary>
        public int Seq { get; set; }

        /// <summary>
        /// Mã tiền
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Giá trị
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Thời gian nhận tiền thành công
        /// </summary>
        public DateTime paymentTime { get; set; }
    }
}