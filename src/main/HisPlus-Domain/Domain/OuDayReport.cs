using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

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
    }
}
