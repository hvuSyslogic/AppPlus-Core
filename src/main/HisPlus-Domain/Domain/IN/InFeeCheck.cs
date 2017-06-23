using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class InFeeCheck : EntityBase<int>
    {
        public InFeeCheck()
        {    
        }

        public int? DetailId { get; set; }
        public int? AdviceId { get; set; }
        public short? LsMarkType { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
