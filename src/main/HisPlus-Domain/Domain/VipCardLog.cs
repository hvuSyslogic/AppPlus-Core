using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class VipCardLog : EntityBase<int>
    {
        public VipCardLog()
        {    
        }

        public int? VipCardId { get; set; }
        public string OldCardNo { get; set; }
        public string NewCardNo { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
    }
}
