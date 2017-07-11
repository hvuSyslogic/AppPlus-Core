using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

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
    }
}
