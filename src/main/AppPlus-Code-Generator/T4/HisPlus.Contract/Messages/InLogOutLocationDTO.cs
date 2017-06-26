using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InLogOutLocationDTO : DtoBase<int>
    {
        public InLogOutLocationDTO()
        {
        }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? InLocId { get; set; }

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
