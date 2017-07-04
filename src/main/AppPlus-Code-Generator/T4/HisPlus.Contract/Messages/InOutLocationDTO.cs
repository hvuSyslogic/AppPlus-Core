using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InOutLocationDTO : DtoBase<int>
    {
        public InOutLocationDTO()
        {
        }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public int BedId { get; set; }

        [DataMember]
        public int OutLocId { get; set; }

        [DataMember]
        public System.DateTime? OutOperTime { get; set; }

        [DataMember]
        public int? OutOperId { get; set; }

        [DataMember]
        public bool? IsReceived { get; set; }

        [DataMember]
        public int? InLocId { get; set; }

        [DataMember]
        public System.DateTime? InOperTime { get; set; }

        [DataMember]
        public int? InOperId { get; set; }
    }
}
