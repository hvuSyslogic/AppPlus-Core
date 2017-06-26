using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OaDocReaderDTO : DtoBase<int>
    {
        public OaDocReaderDTO()
        {
        }

        [DataMember]
        public int? DocId { get; set; }

        [DataMember]
        public int? AllowOperId { get; set; }

        [DataMember]
        public System.DateTime? ExpireTime { get; set; }

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
