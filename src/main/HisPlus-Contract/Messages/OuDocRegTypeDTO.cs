using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuDocRegTypeDTO : DtoBase<int>
    {
        public OuDocRegTypeDTO()
        {
        }

        [DataMember]
        public System.DateTime RegDate { get; set; }

        [DataMember]
        public int? WeekPlanId { get; set; }

        [DataMember]
        public int DoctorId { get; set; }

        [DataMember]
        public int RegTypeId { get; set; }

        [DataMember]
        public int TimeSpanId { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public int? DiagRoomId { get; set; }

        [DataMember]
        public short? LimitNum { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public int? Iscancel { get; set; }

        [DataMember]
        public int? Lastlimitnum { get; set; }
    }
}
