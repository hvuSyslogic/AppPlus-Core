using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class VipChargeItem : EntityBase<int>
    {
        public VipChargeItem()
        {    
        }

        public int? VccId { get; set; }
        public int? ItemId { get; set; }
        public int? TotalCount { get; set; }
        public decimal? DiscountPrice { get; set; }
        public bool? IsDisCount { get; set; }
    }
}
