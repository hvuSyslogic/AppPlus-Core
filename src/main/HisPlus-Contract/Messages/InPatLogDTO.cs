using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InPatLogDTO : DtoBase<int>
    {
        public InPatLogDTO()
        {
        }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public string ActType { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public string BedName { get; set; }
    }
}
