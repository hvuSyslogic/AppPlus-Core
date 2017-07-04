using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OaDocKeyDTO : DtoBase<int>
    {
        public OaDocKeyDTO()
        {
        }

        [DataMember]
        public int? DocId { get; set; }

        [DataMember]
        public string WordKey { get; set; }
    }
}
