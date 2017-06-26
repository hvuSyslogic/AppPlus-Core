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
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public int? FrequencyId { get; set; }
    }
}
