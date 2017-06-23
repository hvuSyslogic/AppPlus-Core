using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class OuDayReport : EntityBase<int>
    {
        public OuDayReport()
        {    
        }

        public string RtpNo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Remark { get; set; }
        public decimal Beprice { get; set; }
        public decimal FactGet { get; set; }
        public decimal? InArrear { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
