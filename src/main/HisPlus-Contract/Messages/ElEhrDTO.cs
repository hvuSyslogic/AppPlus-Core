using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class ElEhrDTO : DtoBase<int>
    {
        public ElEhrDTO()
        {
        }

        [DataMember]
        public string RecNo { get; set; }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public System.DateTime? ModifyOperTime { get; set; }

        [DataMember]
        public int? ModifyOperId { get; set; }

        [DataMember]
        public int PatMenuId { get; set; }

        [DataMember]
        public byte[] Content { get; set; }

        [DataMember]
        public string XmlFile { get; set; }

        [DataMember]
        public bool IsAuth { get; set; }

        [DataMember]
        public System.DateTime? AuthOperTime { get; set; }

        [DataMember]
        public int? AuthOperId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public byte[] XmlContent { get; set; }

        [DataMember]
        public bool? IsRealease { get; set; }

        [DataMember]
        public System.DateTime? RealeaseTime { get; set; }

        [DataMember]
        public int? RealeaseOperId { get; set; }

        [DataMember]
        public bool? IsPrint { get; set; }

        [DataMember]
        public System.DateTime? PrintTime { get; set; }

        [DataMember]
        public int? PrintOperId { get; set; }

        [DataMember]
        public bool? IsClosed { get; set; }

        [DataMember]
        public System.DateTime? ClosedTime { get; set; }

        [DataMember]
        public int? ClosedOperId { get; set; }

        [DataMember]
        public bool? IsCheck { get; set; }
    }
}
