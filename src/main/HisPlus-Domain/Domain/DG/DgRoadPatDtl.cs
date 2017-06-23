using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class DgRoadPatDtl : EntityBase<int>
    {
        public DgRoadPatDtl()
        {    
        }

        public int? RoadPatId { get; set; }
        public int RoadDtlId { get; set; }
        public int? DayGroupId { get; set; }
        public int? CureId { get; set; }
        public int? DrugId { get; set; }
        public int? CheckId { get; set; }
        public int? NurseId { get; set; }
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
        public bool? IsDelete { get; set; }
        public bool? IsChange { get; set; }
        public string Reason { get; set; }
        public int AdviceId { get; set; }
        public short LsMarkType { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
