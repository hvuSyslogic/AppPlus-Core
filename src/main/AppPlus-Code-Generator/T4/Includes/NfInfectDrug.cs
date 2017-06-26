using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class NfInfectDrug : EntityBase<int>
    {
        public NfInfectDrug()
        {    
        }

        public int InfectId { get; set; }
        public int BaseDrugId { get; set; }
        public decimal Dosage { get; set; }
        public int? UnitTakeId { get; set; }
        public int? FrequencyId { get; set; }
        public int? UsageId { get; set; }
        public short? Days { get; set; }
    }
}
