using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblEmailUserDTO : DtoBase<int>
    {
        public GblEmailUserDTO()
        {
        }

        [DataMember]
        public int EmailId { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public bool? IsRead { get; set; }

        [DataMember]
        public System.DateTime? ReadTime { get; set; }
    }
}
