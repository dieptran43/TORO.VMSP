using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TORO.VMPS.Models
{
    public class BillDto
    {
        public BillDto()
        {
            BillsDetails = new List<BillDetailListDto>();
            ShippingDetails = new List<ShippingDetailListDto>();
            CashInfos = new List<CashInfoDto>();
        }

        public int BillNumber { get; set; }

        /// <summary>
        /// NEW/PAYMENTED/SHIPPED
        /// </summary>
        public string PaymentStatus { get; set; }

        /// <summary>
        /// Thời gian bắt đầu tạo bill (Local VM)
        /// </summary>
        public DateTime OrderTime { get; set; }

        /// <summary>
        /// 1 là BuyToro, 2 Buy Voucher, 3 By Cash, 4 Buy GrabPay, 5 Buy V-more, 6 Buy MoMo, ...
        /// </summary>
        public string PaymentType { get; set; }

        /// <summary>
        /// Thời gian thanh toán (local VM): Thời gian thanh toán đủ tiền bằng cash hoặc thời gian nhận thông báo thành công từ Rabit
        /// </summary>
        public DateTime PaymentTime { get; set; }

        /// <summary>
        /// Mã giao dịch: Là mã giao dịch cash (VM tạo ra) hoặc các parner ví
        /// </summary>
        public DateTime PartnerTransactionCode { get; set; }

        public int CompanyId { get; set; }

        public string MachineCode { get; set; }

        /// <summary>
        /// Thành tiền cần thanh toán (Đã +- hết khuyến mãi)
        /// </summary>
        public float OrderAmount { get; set; }

        /// <summary>
        /// Số lượng sản phẩm đặt hàng
        /// </summary>
        public int OrderQuantity { get; set; }

        /// <summary>
        /// Thành tiền cần thanh toán (Đã +- hết khuyến mãi và hàng ko rớt)
        /// </summary>
        public float Amount { get; set; }

        /// <summary>
        /// Số lượng sản phẩm rớt thành công
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Thời gian gửi lên server (local VM): Lúc bán hàng xong hoặc lúc đồng bộ
        /// </summary>
        public DateTime SyncTime { get; set; }

        /// <summary>
        /// Danh sách sản phẩm rớt hàng thành công
        /// </summary>
        public List<BillDetailListDto> BillsDetails { get; set; }

        /// <summary>
        /// Danh sách trạng thái rớt hàng
        /// </summary>
        public List<ShippingDetailListDto> ShippingDetails { get; set; }

        /// <summary>
        /// Có giá trị khi thanh toán tiền mặt
        /// </summary>
        public List<CashInfoDto> CashInfos { get; set; }
    }
}