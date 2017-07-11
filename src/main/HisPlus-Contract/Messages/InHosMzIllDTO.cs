using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InHosMzIllDTO : DtoBase<int>
    {
        public InHosMzIllDTO()
        {
        }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public int ListNum { get; set; }

        [DataMember]
        public int? IcdId { get; set; }

        [DataMember]
        public string IllDesc { get; set; }

        [DataMember]
        public short? LsInOut { get; set; }

        [DataMember]
        public short? LsWestChin { get; set; }

        [DataMember]
        public bool? IsInfect { get; set; }

        [DataMember]
        public bool? IsCoincidence { get; set; }

        [DataMember]
        public int? CheckOperId { get; set; }

        [DataMember]
        public System.DateTime? CheckTime { get; set; }

        [DataMember]
        public int? BpGroupId { get; set; }

        [DataMember]
        public bool? IsDg { get; set; }

        [DataMember]
        public bool? IsBp { get; set; }
    }
}
