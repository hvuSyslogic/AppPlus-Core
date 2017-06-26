using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkResult : EntityBase<int>
    {
        public CkResult()
        {    
        }

        public int CheckId { get; set; }
        public int TestId { get; set; }
        public string LastResult { get; set; }
        public string Result { get; set; }
        public short? LsRefFlag { get; set; }
        public bool? IsPanic { get; set; }
        public bool? IsDalta { get; set; }
        public double? DalAbsolute { get; set; }
        public double? DalPercent { get; set; }
        public decimal? LowValue { get; set; }
        public decimal? HighValue { get; set; }
        public decimal? PanicLow { get; set; }
        public decimal? PanicHigh { get; set; }
        public bool? IsPass { get; set; }
        public System.DateTime? ReportDate { get; set; }
        public string ReportBy { get; set; }
        public bool? IsPrint { get; set; }
        public string Memo { get; set; }
        public int? ParentId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string TextRange { get; set; }
        public decimal? Price { get; set; }
        public decimal? Discount { get; set; }
        public int? TestGroupId { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public string F8 { get; set; }
    }
}
