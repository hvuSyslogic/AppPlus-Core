using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InHosUsageItemDTO : DtoBase<int>
    {
        public InHosUsageItemDTO()
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
