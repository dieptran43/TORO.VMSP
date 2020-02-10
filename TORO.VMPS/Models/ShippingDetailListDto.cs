using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TORO.VMPS.Models
{
    public class ShippingDetailListDto
    {
        /// <summary>
        /// Vị trí mua hàng trên máy VM
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Vị trí sản phẩm trên slot
        /// </summary>
        public int Seq { get; set; }

        /// <summary>
        /// 1: Rớt thành công, 0: Thất bại
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Thời gian sản phẩm rớt xuống
        /// </summary>
        public DateTime ShippedTime { get; set; }

        /// <summary>
        /// Giá sản phẩm sau khuyến mãi
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Mã sản phẩm
        /// </summary>
        public string ProductId { get; set; }
    }
}