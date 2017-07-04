using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OaDocFileDTO : DtoBase<int>
    {
        public OaDocFileDTO()
        {
        }

        [DataMember]
        public int? DocId { get; set; }

        [DataMember]
        public short? LsDocType { get; set; }

        [DataMember]
        public byte[] DocFile { get; set; }
    }
}
