using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class VisitRecordUserDTO : DtoBase<int>
    {
        public VisitRecordUserDTO()
        {
        }

        [DataMember]
        public int? UserId { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public int? LsUserRole { get; set; }
    }
}
