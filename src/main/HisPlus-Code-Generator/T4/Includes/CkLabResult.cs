using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CkLabResult : EntityBase<int>
    {
        public CkLabResult()
        {    
        }

        public int LabId { get; set; }
        public int TestId { get; set; }
        public string LastResult { get; set; }
        public string Result { get; set; }
        public string Unit { get; set; }
        public short LsRefFlag { get; set; }
        public bool IsPanic { get; set; }
        public bool IsDalta { get; set; }
        public decimal DalAbsolute { get; set; }
        public decimal DalPercent { get; set; }
        public decimal LowValue { get; set; }
        public decimal HighValue { get; set; }
        public decimal PanicLow { get; set; }
        public decimal PanicHigh { get; set; }
        public bool IsPass { get; set; }
        public bool IsReport { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsPrint { get; set; }
        public System.DateTime? PrintTime { get; set; }
        public int? PrintOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string TextRange { get; set; }
    }
}
