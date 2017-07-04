using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsItemLocation : EntityBase<int>
    {
        public BsItemLocation()
        {    
        }

        public int LocationId { get; set; }
        public int ItemId { get; set; }
        public int? FeeHsMzId { get; set; }
        public int? FeeHsZyId { get; set; }
        public decimal? Dosage { get; set; }
        public int? UnitTake { get; set; }
        public int? FrequencyId { get; set; }
        public int? UsageId { get; set; }
        public bool IsLocDrug { get; set; }
        public int OrderBy { get; set; }
        public short IconIndex { get; set; }
        public int? ExecLocId { get; set; }
        public bool? IsLocUse { get; set; }
    }
}
