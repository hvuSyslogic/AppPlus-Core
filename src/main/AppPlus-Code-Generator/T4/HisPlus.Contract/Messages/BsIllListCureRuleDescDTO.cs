using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    // The table 'BsIllListCureRuleDesc' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    [Serializable]
    [DataContract]
    public class BsIllListCureRuleDescDTO
    {
        public BsIllListCureRuleDescDTO()
        {
        }

        [DataMember]
        public string 疾病 { get; set; }

        [DataMember]
        public string 患者分组 { get; set; }

        [DataMember]
        public string 治疗原则 { get; set; }

        [DataMember]
        public string 小字说明 { get; set; }

        [DataMember]
        public int? 排序 { get; set; }

        [DataMember]
        public int? 分组排序 { get; set; }

        [DataMember]
        public System.DateTime? ImpTime { get; set; }

        [DataMember]
        public int? BpIllId { get; set; }

        [DataMember]
        public int? BpGroupId { get; set; }
    }
}
