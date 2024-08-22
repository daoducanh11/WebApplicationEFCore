using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIC_TT15.Core.Entities
{
    /// <summary>
    ///  TB_D10_TOCHUC_TC024: VỐN ĐIỀU LỆ
    ///  PrimaryKey: (TTC03,TC0241)
    ///  ForeignKey: TB_D10|TTC03		
    /// </summary>
    public class D10_TOCHUC_TC024
    {
        /// <summary>
        /// MAKH-Mã khách hàng do TCTD cấp
        /// </summary>
        [MaxLength(50)]
        public string TTC03 { get; set; }

        /// <summary>
        /// MANT-Mã tiền tệ
        /// </summary>
        [MaxLength(3)]
        [Key]
        public string TC0241 { get; set; }

        /// <summary>
        /// VONDL-Số tiền vốn điều lệ
        /// </summary>
        [Range(0, 999999999999999)]
        public decimal? TC0242 { get; set; }

        [ForeignKey("TTC03")]
        public D10_TOCHUC d10_TOCHUC { get; set; }
    }
}
