using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class InDrugReqdtlA : EntityBase<System.DateTime>
    {
        public InDrugReqdtlA()
        {    
        }

        public int? UnitTake { get; set; }
        public int? FrequencyId { get; set; }
        public int? UsageId { get; set; }
        public int? ConfirmOperId { get; set; }
        public System.DateTime? ConfirmOperTime { get; set; }
        public int? DetailId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? ExecuteId { get; set; }
        public string RegDate { get; set; }
    }
}
