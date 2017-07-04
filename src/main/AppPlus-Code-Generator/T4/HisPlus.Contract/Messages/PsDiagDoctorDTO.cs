using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class PsDiagDoctorDTO : DtoBase<int>
    {
        public PsDiagDoctorDTO()
        {
        }

        [DataMember]
        public int? ApplyId { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public bool? IsConfirm { get; set; }

        [DataMember]
        public System.DateTime? ConfirmTime { get; set; }

        [DataMember]
        public string Answer { get; set; }
    }
}
