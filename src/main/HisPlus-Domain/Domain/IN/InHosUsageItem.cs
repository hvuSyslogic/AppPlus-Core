using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class InHosUsageItem : EntityBase<int>
    {
        public InHosUsageItem()
        {    
        }

        public int? UsageId { get; set; }
        public int? GroupNum { get; set; }
        public string UsageMemo { get; set; }
        public string AdviceMemo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? FrequencyId { get; set; }
    }
}
