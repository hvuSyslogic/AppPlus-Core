using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class TrDoctorEmrDTO : DtoBase<int>
    {
        public TrDoctorEmrDTO()
        {
        }

        [DataMember]
        public int DoctorId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int PatId { get; set; }
    }
}
