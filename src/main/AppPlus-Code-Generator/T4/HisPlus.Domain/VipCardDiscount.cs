using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class VipCardDiscount : EntityBase<int>
    {
        public VipCardDiscount()
        {    
        }

        public int? VipCardId { get; set; }
        public int? FeeId { get; set; }
        public decimal? Discount { get; set; }
    }
}
