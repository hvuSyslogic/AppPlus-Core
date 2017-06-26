using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class DgIllCure : EntityBase<int>
    {
        public DgIllCure()
        {    
        }

        public int? IllId { get; set; }
        public int? IllGroupId { get; set; }
        public int? CureId { get; set; }
        public int? DrugId { get; set; }
        public int? CheckId { get; set; }
        public int? NurseId { get; set; }
        public short? LsAdvType { get; set; }
        public short? LsCureType { get; set; }
        public bool? IsBaby { get; set; }
        public bool? IsWomen { get; set; }
        public bool? IsMen { get; set; }
        public bool? IsOlder { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public decimal? Dosage { get; set; }
        public int? UnitTakeId { get; set; }
        public int? FrequencyId { get; set; }
        public int? UsageId { get; set; }
        public short? Days { get; set; }
        public decimal? FeeTotality { get; set; }
        public int? UnitId { get; set; }
    }
}
