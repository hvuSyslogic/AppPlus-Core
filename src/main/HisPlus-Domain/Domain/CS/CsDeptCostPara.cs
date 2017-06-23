using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CsDeptCostPara : EntityBase<int>
    {
        public CsDeptCostPara()
        {    
        }

        public int LocId { get; set; }
        public int CostSubjId { get; set; }
        public short? LsAppPara { get; set; }
        public string ToLocIds { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
