namespace CIC_TT15.Core.Models
{
    public class D32_CHOVAYModel
    {
        public string YYYYMMDD { get; set; }

        public string TTC01 { get; set; }

        public string TTC02 { get; set; }

        public string TTC03 { get; set; }

        public string TTC04 { get; set; }

        public string HD001 { get; set; }

        public DateTime? HD002 { get; set; }

        public DateTime? HD003 { get; set; }

        public decimal? HD004 { get; set; }

        public decimal? HD005 { get; set; }
    }

    public class D32_CHOVAY_KHEUOCModel
    {
        public string YYYYMMDD { get; set; }

        public string TTC01 { get; set; }

        public string TTC03 { get; set; }

        public string TTC04 { get; set; }

        public string HD001 { get; set; }

        public string KU001 { get; set; }

        public DateTime? KU002 { get; set; }

        public DateTime? KU003 { get; set; }

        public decimal? KU004 { get; set; }

        public string KU005 { get; set; }

        public string KU006 { get; set; }

        public string KU007 { get; set; }

        public DateTime? KU008 { get; set; }

        public string KU009 { get; set; }

        public decimal? KU010 { get; set; }

        public decimal? KU011 { get; set; }

        public string KU012 { get; set; }

        public string KU013 { get; set; }

        public decimal? KU014 { get; set; }

        public DateTime? KU015 { get; set; }

        public decimal? KU016 { get; set; }

        public DateTime? KU017 { get; set; }

        public decimal? KU018 { get; set; }

        public decimal? KU019 { get; set; }

        public decimal? KU020 { get; set; }

        public string KU021 { get; set; }
        
        public string KU023 { get; set; }

        public decimal? KU024 { get; set; }

        public decimal? KU025 { get; set; }

        public decimal? KU026 { get; set; }

        public decimal? KU027 { get; set; }
    }

    public class D32_CHOVAY_KHEUOC__D32_CHOVAY_KHEUOCModel : D32_CHOVAYModel
    {
        public List<D32_CHOVAY_KHEUOCModel> d32_CHOVAY_KHEUOCModels { get; set; }
    }
}
