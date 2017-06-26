using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CsDeptCost : EntityBase<int>
    {
        public CsDeptCost()
        {    
        }

        public string YearMonth { get; set; }
        public int LocId { get; set; }
        public int? CostSubjId { get; set; }
        public decimal? TotAmount { get; set; }
        public decimal? PlanAmount { get; set; }
        public decimal? PrimeCost { get; set; }
        public decimal? ApportCost1 { get; set; }
        public decimal? ApportCost2 { get; set; }
        public decimal? ApportCost3 { get; set; }
        public decimal? ApportCost4 { get; set; }
        public decimal? ApportCostSend { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
