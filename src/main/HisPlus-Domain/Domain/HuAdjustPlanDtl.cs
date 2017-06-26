using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class HuAdjustPlanDtl : EntityBase<int>
    {
        public HuAdjustPlanDtl()
        {    
        }

        public int BillId { get; set; }
        public int ItemId { get; set; }
        public decimal NewPrice { get; set; }
        public decimal OldPrice { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
