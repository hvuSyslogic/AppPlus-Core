using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InLogInHospitalDTO : DtoBase<int>
    {
        public InLogInHospitalDTO()
        {
        }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? LsInIllness { get; set; }
    }
}
