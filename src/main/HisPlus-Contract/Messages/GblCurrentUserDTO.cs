using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblCurrentUserDTO : DtoBase<int>
    {
        public GblCurrentUserDTO()
        {
        }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public int? HouseId { get; set; }

        [DataMember]
        public int? RoomId { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public string Hostname { get; set; }

        [DataMember]
        public int? SpecialityId { get; set; }

        [DataMember]
        public System.DateTime? BeginTime { get; set; }

        [DataMember]
        public System.DateTime? EndTime { get; set; }
    }
}
