using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class HuAdjustPlan : EntityBase<int>
    {
        public HuAdjustPlan()
        {    
        }

        public string BillNo { get; set; }
        public int HouseId { get; set; }
        public System.DateTime NotifyDate { get; set; }
        public string DispUnit { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Memo { get; set; }
    }
}
