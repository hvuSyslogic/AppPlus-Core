using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

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
        public bool? IsSign { get; set; }
    }
}
