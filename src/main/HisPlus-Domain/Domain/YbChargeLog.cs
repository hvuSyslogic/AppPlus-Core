using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class YbChargeLog : EntityBase<int>
    {
        public YbChargeLog()
        {    
        }

        public string YbReqNo { get; set; }
        public string InvoNo { get; set; }
        public int? HospId { get; set; }
        public int? MzRegId { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public bool? IsCancel { get; set; }
        public int? CancelOperId { get; set; }
        public System.DateTime? CancelOperTime { get; set; }
    }
}
