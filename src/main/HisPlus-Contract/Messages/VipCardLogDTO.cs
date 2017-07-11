using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class VipCardLogDTO : DtoBase<int>
    {
        public VipCardLogDTO()
        {
        }

        [DataMember]
        public int? VipCardId { get; set; }

        [DataMember]
        public string OldCardNo { get; set; }

        [DataMember]
        public string NewCardNo { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? OperId { get; set; }
    }
}
