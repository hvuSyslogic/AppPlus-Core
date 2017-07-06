using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class VipReckoningCharge : EntityBase<int>
    {
        public VipReckoningCharge()
        {    
        }

        public int? VipCardId { get; set; }
        public int? ItemId { get; set; }
        public int? TotalCount { get; set; }
        public int? ConsumeCount { get; set; }
        public System.DateTime? LastChargeTime { get; set; }
        public decimal? DiscountPrice { get; set; }
        public bool? IsDiscount { get; set; }
        public bool? IsActive { get; set; }
        public string Comments { get; set; }
    }
}
