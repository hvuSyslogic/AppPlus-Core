using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class ElPatFormDrug : EntityBase<int>
    {
        public ElPatFormDrug()
        {    
        }

        public int? PatFormId { get; set; }
        public int? ListNum { get; set; }
        public int? ItemId { get; set; }
        public short? GroupNum { get; set; }
        public decimal? Dosage { get; set; }
        public int? UnitTakeId { get; set; }
        public int? FrequencyId { get; set; }
        public int? UsageId { get; set; }
        public short? Days { get; set; }
        public decimal? Totality { get; set; }
        public int? UnitDiagId { get; set; }
        public bool? IsAttach { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
