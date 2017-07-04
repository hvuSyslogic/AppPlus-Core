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
        public string IllName { get; set; }

        [DataMember]
        public string PatGroup { get; set; }

        [DataMember]
        public string CureTenet { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public int? OrderBy { get; set; }

        [DataMember]
        public int? GroupOrderBy { get; set; }

        [DataMember]
        public System.DateTime? ImpTime { get; set; }

        [DataMember]
        public int? BpIllId { get; set; }

        [DataMember]
        public int? BpGroupId { get; set; }
    }
}
