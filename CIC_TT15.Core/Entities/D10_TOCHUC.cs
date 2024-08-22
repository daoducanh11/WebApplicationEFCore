using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIC_TT15.Core.Entities
{
    /// <summary>
    ///  TB_D10_TOCHUC: THÔNG TIN HỒ SƠ PHÁP LÝ KHÁCH HÀNG TỔ CHỨC
    ///  PrimaryKey: (TTC03)
    ///  ForeignKey: [ForeignKey]		
    /// </summary>
    [Table("D10_TOCHUC")]
    public class D10_TOCHUC
    {
        /// <summary>
        /// MAKH-Mã khách hàng do TCTD cấp
        /// </summary>
        [MaxLength(50)]
        [Key]
        [Description("Mã khách hàng do TCTD cấp")]
        public string TTC03 { get; set; }

        /// <summary>
        /// TENKH-Tên khách hàng
        /// </summary>
        [MaxLength(250)]
        [Required]
        public string TTC04 { get; set; }

        /// <summary>
        /// LOAIKH-Loại khách hàng
        /// </summary>
        [Range(0, 1)]
        public decimal? TTC05 { get; set; }

        /// <summary>
        /// TENDNG-Tên đối ngoại
        /// </summary>
        [MaxLength(250)]
        public string TC001 { get; set; }

        /// <summary>
        /// TENVT-Tên viết tắt
        /// </summary>
        [MaxLength(100)]
        public string TC002 { get; set; }

        /// <summary>
        /// TENCU-Tên cũ
        /// </summary>
        [MaxLength(250)]
        public string TC003 { get; set; }

        /// <summary>
        /// DIACHI-Địa chỉ
        /// </summary>
        [MaxLength(300)]
        public string TC004 { get; set; }

        /// <summary>
        /// MATINH-Mã tỉnh, thành phố trực thuộc trung ương
        /// </summary>
        [MaxLength(2)]
        public string TC005 { get; set; }

        /// <summary>
        /// CUTRU-Cư trú
        /// </summary>
        [Range(0, 1)]
        public decimal? TC006 { get; set; }

        /// <summary>
        /// DTHOAI-Điện thoại
        /// </summary>
        [MaxLength(100)]
        public string TC007 { get; set; }

        /// <summary>
        /// FAX-Fax
        /// </summary>
        [MaxLength(50)]
        public string TC008 { get; set; }

        /// <summary>
        /// WEBSITE-Website
        /// </summary>
        [MaxLength(150)]
        public string TC009 { get; set; }

        /// <summary>
        /// EMAIL-Email
        /// </summary>
        [MaxLength(150)]
        public string TC010 { get; set; }

        /// <summary>
        /// MASODN-Mã số doanh nghiệp
        /// </summary>
        [MaxLength(20)]
        public string TC011 { get; set; }

        /// <summary>
        /// NGMSDN-Ngày cấp mã số doanh nghiệp
        /// </summary>
        public DateTime? TC012 { get; set; }

        /// <summary>
        /// SOQDTL-Số quyết định thành lập
        /// </summary>
        [MaxLength(20)]
        public string TC013 { get; set; }

        /// <summary>
        /// NGQDTL-Ngày cấp quyết định thành lập
        /// </summary>
        public DateTime? TC014 { get; set; }

        /// <summary>
        /// SOGPDT-Số Giấy phép đầu tư
        /// </summary>
        [MaxLength(20)]
        public string TC015 { get; set; }

        /// <summary>
        /// NGGPDT-Ngày cấp giấy phép đầu tư
        /// </summary>
        public DateTime? TC016 { get; set; }

        /// <summary>
        /// MALH-Mã loại hình doanh nghiệp/tổ chức khác
        /// </summary>
        [MaxLength(3)]
        public string TC017 { get; set; }

        /// <summary>
        /// MANKT-Mã ngành nghề kinh doanh
        /// </summary>
        [MaxLength(3)]
        public string TC018 { get; set; }

        /// <summary>
        /// HOTENGD-Tổng Giám đốc/Giám đốc
        /// </summary>
        [MaxLength(250)]
        public string TC019 { get; set; }

        /// <summary>
        /// DIACHIGD-Địa chỉ Tổng Giám đốc/Giám đốc
        /// </summary>
        [MaxLength(300)]
        public string TC020 { get; set; }

        /// <summary>
        /// GIAYTOCNGD-Số CCCD/CMND/Hộ chiếu Tổng Giám đốc/Giám đốc
        /// </summary>
        [MaxLength(12)]
        public string TC021 { get; set; }

        /// <summary>
        /// TVQTDND-Là thành viên của Quỹ tín dụng nhân dân (TDND)
        /// </summary>
        [Range(0, 1)]
        public decimal? TC022 { get; set; }

        /// <summary>
        /// TVHTX-Là thành viên của Ngân hàng hợp tác xã
        /// </summary>
        [Range(0, 1)]
        public decimal? TC023 { get; set; }

        public virtual ICollection<D10_TOCHUC_TC024> D10_TOCHUC_TC024s { get; set; }
    }
}
