using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class TraceDTO : DtoBase<int>
    {
        public TraceDTO()
        {
        }

        [DataMember]
        public System.DateTime CreateDate { get; set; }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public string Ip { get; set; }

        [DataMember]
        public string Messages { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string OperateType { get; set; }

        [DataMember]
        public int? RecordId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
