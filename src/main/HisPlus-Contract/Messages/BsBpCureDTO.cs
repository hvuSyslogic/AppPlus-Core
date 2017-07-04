using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsBpCureDTO : DtoBase<int>
    {
        public BsBpCureDTO()
        {
        }

        [DataMember]
        public string CureRuleName { get; set; }

        [DataMember]
        public string CureRuleDesc { get; set; }

        [DataMember]
        public int? BpIllId { get; set; }

        [DataMember]
        public int? BpGroupId { get; set; }

        [DataMember]
        public int? OrderBy { get; set; }
    }
}
