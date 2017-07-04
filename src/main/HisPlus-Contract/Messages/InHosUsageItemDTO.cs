using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InHosUsageItemDTO : DtoBase<int>
    {
        public InHosUsageItemDTO()
        {
        }

        [DataMember]
        public int? UsageId { get; set; }

        [DataMember]
        public int? GroupNum { get; set; }

        [DataMember]
        public string UsageMemo { get; set; }

        [DataMember]
        public string AdviceMemo { get; set; }

        [DataMember]
        public int? FrequencyId { get; set; }

        [DataMember]
        public System.DateTime? ChargeTime { get; set; }
    }
}
