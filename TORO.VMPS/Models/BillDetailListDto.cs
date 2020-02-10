using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TORO.VMPS.Models
{
    public class BillDetailListDto
    {
        /// <summary>
        /// Vị trí mua hàng trên máy VM
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Số lượng sản phẩm đặt hàng
        /// </summary>
        public int OrderQuantity { get; set; }

        /// <summary>
        /// Số lượng sản phẩm
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Giá sản phẩm
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// Giá sản phẩm sau khuyến mãi
        /// </summary>
        public float FinalPrice { get; set; }

        /// <summary>
        /// Mã sản phẩm
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// Vị trí sản phẩm trên slot
        /// </summary>
        public string ImportId { get; set; }

        /// <summary>
        /// Ngày hết hạn của sản phẩm
        /// </summary>
        public DateTime ExpiredDate { get; set; }
    }
}