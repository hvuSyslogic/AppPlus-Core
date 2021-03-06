using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkLabDtlDTO : DtoBase<int>
    {
        public CkLabDtlDTO()
        {
        }

        [DataMember]
        public int LabId { get; set; }

        [DataMember]
        public int TestId { get; set; }

        [DataMember]
        public int? SourceId { get; set; }

        [DataMember]
        public int? TubeTypeId { get; set; }

        [DataMember]
        public bool IsDownLoad { get; set; }

        [DataMember]
        public bool IsPrint { get; set; }

        [DataMember]
        public System.DateTime? PrintTime { get; set; }

        [DataMember]
        public int? PrintOperId { get; set; }

        [DataMember]
        public bool IsBilled { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public int? ParentId { get; set; }

        [DataMember]
        public int? RecipeDtlId { get; set; }

        [DataMember]
        public int? DetailId { get; set; }

        [DataMember]
        public string ItemId { get; set; }
    }
}
