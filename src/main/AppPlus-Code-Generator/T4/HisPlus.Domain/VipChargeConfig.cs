using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class VipChargeConfig : EntityBase<int>
    {
        public VipChargeConfig()
        {    
        }

        public int? Viplevelid { get; set; }
        public decimal? Balance { get; set; }
        public decimal? Givingintegral1 { get; set; }
        public decimal? Givingintegral2 { get; set; }
    }
}
