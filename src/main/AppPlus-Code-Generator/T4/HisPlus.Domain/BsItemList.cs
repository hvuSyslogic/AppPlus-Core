using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsItemList : EntityBase<int>
    {
        public BsItemList()
        {    
        }

        public int? IllId { get; set; }
        public string IllName { get; set; }
        public int? GroupId { get; set; }
        public string PatientGroup { get; set; }
        public int? UnDrugId { get; set; }
        public string UnDrugName { get; set; }
        public int? TypeCode { get; set; }
        public int? ItemId { get; set; }
        public string ItemName { get; set; }
        public int? UnitId { get; set; }
        public string UnitName { get; set; }
        public int? UsageId { get; set; }
        public string UsageName { get; set; }
        public int? FrequencyId { get; set; }
        public string FrequencyName { get; set; }
        public decimal? Quantity { get; set; }
        public int? RelationCode { get; set; }
        public string WayCode { get; set; }
        public string Remark { get; set; }
        public System.DateTime? ImpTime { get; set; }
    }
}
