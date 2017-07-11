using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public decimal? Before { get; set; }
        public decimal? Progress { get; set; }
        public decimal? After { get; set; }
    }
}
