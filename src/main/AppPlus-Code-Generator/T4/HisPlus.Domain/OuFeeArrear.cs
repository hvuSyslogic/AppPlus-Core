using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OuFeeArrear : EntityBase<int>
    {
        public OuFeeArrear()
        {    
        }

        public int? PatId { get; set; }
        public int? MzRegId { get; set; }
        public int? ItemId { get; set; }
        public decimal? Amount { get; set; }
        public bool? IsPay { get; set; }
        public System.DateTime? PayTime { get; set; }
    }
}
