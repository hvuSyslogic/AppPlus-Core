using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsUsageItem : EntityBase<int>
    {
        public BsUsageItem()
        {    
        }

        public int UsageId { get; set; }
        public int ItemId { get; set; }
        public decimal Totality { get; set; }
        public short LsUseArea { get; set; }
        public int? LocationId { get; set; }
        public short IconIndex { get; set; }
        public bool? IsBaby { get; set; }
        public bool? IsWomen { get; set; }
        public bool? IsMen { get; set; }
        public bool? IsOlder { get; set; }
        public string Memo { get; set; }
        public bool? IsDrugTwoDay { get; set; }
    }
}
