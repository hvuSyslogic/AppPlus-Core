using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CkItemQc : EntityBase<int>
    {
        public CkItemQc()
        {    
        }

        public int TestId { get; set; }
        public string QcName { get; set; }
        public decimal? Dev3 { get; set; }
        public decimal? Dev2 { get; set; }
        public decimal? Dev1 { get; set; }
        public decimal? DevM1 { get; set; }
        public decimal? DevM2 { get; set; }
        public decimal? DevM3 { get; set; }
        public decimal? AvgValue { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? CtrlId { get; set; }
    }
}
