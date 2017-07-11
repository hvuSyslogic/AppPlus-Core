using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsDocRegTypeDTO : DtoBase<int>
    {
        public BsDocRegTypeDTO()
        {
        }

        [DataMember]
        public int DoctorId { get; set; }

        [DataMember]
        public int RegTypeId { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public short? LimitNum { get; set; }

        [DataMember]
        public System.DateTime? LastLimitDate { get; set; }

        [DataMember]
        public short? LastLimitNum { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }

        [DataMember]
        public short WeekDay { get; set; }

        [DataMember]
        public int TimeSpanId { get; set; }

        [DataMember]
        public string RoomNo { get; set; }

        [DataMember]
        public int? Diagroomid { get; set; }
    }
}
