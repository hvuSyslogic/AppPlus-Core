using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OpsManDTO : DtoBase<int>
    {
        public OpsManDTO()
        {
        }

        [DataMember]
        public int ApplyId { get; set; }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public short LsRole { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? DocLevId { get; set; }

        [DataMember]
        public string Memo { get; set; }
    }
}
