using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OaDocumentDTO : DtoBase<int>
    {
        public OaDocumentDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int? GroupMainId { get; set; }

        [DataMember]
        public int? GroupSubId { get; set; }

        [DataMember]
        public short? LsOpenType { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }

        [DataMember]
        public string InActiveReason { get; set; }

        [DataMember]
        public System.DateTime? InActiveTime { get; set; }

        [DataMember]
        public int? InActiveOperId { get; set; }

        [DataMember]
        public short? IconIndex { get; set; }

        [DataMember]
        public short? Security { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}
