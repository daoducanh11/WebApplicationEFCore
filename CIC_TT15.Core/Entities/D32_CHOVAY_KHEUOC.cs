using System.ComponentModel.DataAnnotations;

namespace CIC_TT15.Core.Entities
{
    /// <summary>
    ///  TB_D32_CHOVAY_KHEUOC: THÔNG TIN KHẾ ƯỚC
    ///  PrimaryKey: (YYYYMMDD,TTC01,TTC03,HD001,KU001)
    ///  ForeignKey: TB_D32_CHOVAY|YYYYMMDD|TTC01|TTC03|HD001		
    /// </summary>
    public class D32_CHOVAY_KHEUOC
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
        /// SOKU-Số khế ước
        /// </summary>
        [MaxLength(100)]
        public string KU001 { get; set; }

        /// <summary>
        /// NGGIAINGAN-Ngày giải ngân
        /// </summary>
        public DateTime? KU002 { get; set; }

        /// <summary>
        /// NGKTKU-Ngày kết thúc khế ước
        /// </summary>
        public DateTime? KU003 { get; set; }

        /// <summary>
        /// DIENTU-Hoạt động cấp tín dụng bằng phương tiện điện tử
        /// </summary>
        [Range(0, 1)]
        public decimal? KU004 { get; set; }

        /// <summary>
        /// MATHOIHAN-Mã thời hạn cấp tín dụng
        /// </summary>
        [MaxLength(2)]
        public string KU005 { get; set; }

        /// <summary>
        /// MAHTCAPTD-Hình thức cấp tín dụng
        /// </summary>
        [MaxLength(3)]
        public string KU006 { get; set; }

        /// <summary>
        /// MAPTHUCCV-Phương thức cho vay
        /// </summary>
        [MaxLength(3)]
        public string KU007 { get; set; }

        /// <summary>
        /// NGTRUYDOI-Thời điểm truy đòi
        /// </summary>
        public DateTime? KU008 { get; set; }

        /// <summary>
        /// MANT-Mã tiền tệ
        /// </summary>
        [MaxLength(3)]
        public string KU009 { get; set; }

        /// <summary>
        /// DUNO-Số dư nợ theo nguyên tệ
        /// </summary>
        [Range(0, 999999999999999)]
        public decimal? KU010 { get; set; }

        /// <summary>
        /// LAISUAT-Lãi suất
        /// </summary>
        [Range(0, 99999)]
        public decimal? KU011 { get; set; }

        /// <summary>
        /// NHOMNO-Nhóm nợ tự phân loại
        /// </summary>
        [MaxLength(2)]
        public string KU012 { get; set; }

        /// <summary>
        /// NHOMNOSTC-Nhóm nợ phân loại sau khi tham chiếu CIC
        /// </summary>
        [MaxLength(2)]
        public string KU013 { get; set; }

        /// <summary>
        /// STGOCCHAMTN-Dư nợ gốc chậm trả thực tế
        /// </summary>
        [Range(0, 999999999999999)]
        public decimal? KU014 { get; set; }

        /// <summary>
        /// NGCHAMTGOC-Ngày chậm trả nợ gốc
        /// </summary>
        public DateTime? KU015 { get; set; }

        /// <summary>
        /// STLAICHAMTN-Số tiền lãi chậm trả thực tế
        /// </summary>
        [Range(0, 999999999999999)]
        public decimal? KU016 { get; set; }

        /// <summary>
        /// NGCHAMTLAI-Ngày chậm trả nợ lãi
        /// </summary>
        public DateTime? KU017 { get; set; }

        /// <summary>
        /// SOLANCC-Số lần cơ cấu lại thời hạn trả nợ
        /// </summary>
        [Range(0, 999)]
        public decimal? KU018 { get; set; }

        /// <summary>
        /// STGOCCC-Số tiền nợ gốc cơ cấu
        /// </summary>
        [Range(0, 999999999999999)]
        public decimal? KU019 { get; set; }

        /// <summary>
        /// STLAICC-Số tiền nợ lãi cơ cấu
        /// </summary>
        [Range(0, 999999999999999)]
        public decimal? KU020 { get; set; }

        /// <summary>
        /// MAMDSDTVNKT-Mục đích sử dụng tiền vay phân theo ngành kinh tế
        /// </summary>
        [MaxLength(3)]
        public string KU021 { get; set; }

        /// <summary>
        /// MOTAMDSDTV-Mô tả mục đích sử dụng tiền vay
        /// </summary>
        [MaxLength(4000)]
        public string KU023 { get; set; }

        /// <summary>
        /// LCVPTHUNB-Lãi phải thu hạch toán nội bảng
        /// </summary>
        [Range(0, 999999999999999)]
        public decimal? KU024 { get; set; }

        /// <summary>
        /// LCVCTHUNGB-Lãi chưa thu hạch toán ngoại bảng
        /// </summary>
        [Range(0, 999999999999999)]
        public decimal? KU025 { get; set; }

        /// <summary>
        /// DPPTNB-Dự phòng cụ thể phải trích nội bảng
        /// </summary>
        [Range(0, 999999999999999)]
        public decimal? KU026 { get; set; }

        /// <summary>
        /// DPDTNB-Dự phòng cụ thể đã trích nội bảng
        /// </summary>
        [Range(0, 999999999999999)]
        public decimal? KU027 { get; set; }

        public D32_CHOVAY d32_CHOVAY { get; set; }
    }
}
