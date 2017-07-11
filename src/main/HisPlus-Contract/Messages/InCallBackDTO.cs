using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InCallBackDTO : DtoBase<int>
    {
        public InCallBackDTO()
        {
        }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public System.DateTime BackTime { get; set; }

        [DataMember]
        public string Reason { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int? OperId { get; set; }
    }
}
