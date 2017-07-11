using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OpsCharge : EntityBase<int>
    {
        public OpsCharge()
        {    
        }

        public int ApplyId { get; set; }
        public int ListNum { get; set; }
        public int ItemId { get; set; }
        public string Remark { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsTally { get; set; }
        public decimal? Before { get; set; }
        public decimal? Progress { get; set; }
        public decimal? After { get; set; }
    }
}
