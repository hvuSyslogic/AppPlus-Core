using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class DgRoadDtl : EntityBase<int>
    {
        public DgRoadDtl()
        {    
        }

        public int RoadId { get; set; }
        public int? DayGroupId { get; set; }
        public int? CureId { get; set; }
        public int? DrugId { get; set; }
        public int? CheckId { get; set; }
        public int? NurseId { get; set; }
        public string Name { get; set; }
        public string Spec { get; set; }
        public short? LsAdvType { get; set; }
        public short? LsCureType { get; set; }
        public int? CatalogId { get; set; }
        public decimal? Dosage { get; set; }
        public int? UnitTakeId { get; set; }
        public int? FrequencyId { get; set; }
        public int? UsageId { get; set; }
        public short? Days { get; set; }
        public decimal? FeeTotality { get; set; }
        public int? UnitId { get; set; }
        public bool? IsNeed { get; set; }
        public bool? IsReason { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
