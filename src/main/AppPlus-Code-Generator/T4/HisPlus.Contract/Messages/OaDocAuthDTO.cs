using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OaDocAuthDTO : DtoBase<int>
    {
        public OaDocAuthDTO()
        {
        }

        [DataMember]
        public int? DocId { get; set; }

        [DataMember]
        public int? AuthOperId { get; set; }

        [DataMember]
        public short? OrderBy { get; set; }

        [DataMember]
        public bool IsAuth { get; set; }

        [DataMember]
        public System.DateTime? AuthOperTime { get; set; }

        [DataMember]
        public bool? IsReject { get; set; }

        [DataMember]
        public string RejectReason { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public short? LsReadClass { get; set; }
    }
}
