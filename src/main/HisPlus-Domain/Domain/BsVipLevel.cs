using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsVipLevel : EntityBase<int>
    {
        public BsVipLevel()
        {    
        }

        public int? VipTypeId { get; set; }
        public string Name { get; set; }
        public decimal? Discount { get; set; }
        public decimal? DefaultBalance { get; set; }
        public int? OrderBy { get; set; }
        public bool? IsActive { get; set; }
        public int? InValidDays { get; set; }
        public bool? IsVipPrice { get; set; }
        public bool? IsStoredCard { get; set; }
        public string Memo { get; set; }
    }
}
