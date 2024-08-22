using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIC_TT15.Core.Entities
{
    /// <summary>
    ///  TB_D32_CHOVAY: THÔNG TIN HỢP ĐỒNG TÍN DỤNG
    ///  PrimaryKey: (YYYYMMDD,TTC01,TTC03,HD001)
    /// </summary>
    [Table("D32_CHOVAY")]
    public class D32_CHOVAY
    {
        /// <summary>
        /// YYYYMMDD-Ngày số liệu
        /// </summary>
        [MaxLength(8)]
        public string YYYYMMDD { get; set; }

        /// <summary>
        /// MACNTCTD-Mã chi nhánh TCTD
        /// </summary>
        [MaxLength(8)]
        public string TTC01 { get; set; }

        /// <summary>
        /// TENCNTCTD-Tên chi nhánh TCTD
        /// </summary>
        [MaxLength(250)]
        public string TTC02 { get; set; }

        /// <summary>
        /// MAKH-Mã khách hàng do TCTD cấp
        /// </summary>
        [MaxLength(50)]
        public string TTC03 { get; set; }

        /// <summary>
        /// TENKH-Tên khách hàng
        /// </summary>
        [MaxLength(250)]
        public string TTC04 { get; set; }

        /// <summary>
        /// SOHD-Số hợp đồng tín dụng
        /// </summary>
        [MaxLength(100)]
        public string HD001 { get; set; }

        /// <summary>
        /// NGKYHD-Ngày hiệu lực hợp đồng
        /// </summary>
        public DateTime? HD002 { get; set; }

        /// <summary>
        /// NGKTHD-Ngày kết thúc hợp đồng
        /// </summary>
        public DateTime? HD003 { get; set; }

        /// <summary>
        /// THOIHAN-Thời hạn cấp tín dụng (ngày)
        /// </summary>
        [Range(0, 999999)]
        public decimal? HD004 { get; set; }

        /// <summary>
        /// TTTSBD-Trạng thái Tài sản bảo đảm (TSBĐ)
        /// </summary>
        [Range(0, 1)]
        public decimal? HD005 { get; set; }

        public ICollection<D32_CHOVAY_KHEUOC> D32_CHOVAY_KHEUOCs { get; set; }

        public D32_CHOVAY()
        {
            D32_CHOVAY_KHEUOCs = new List<D32_CHOVAY_KHEUOC>();
        }
    }
}
