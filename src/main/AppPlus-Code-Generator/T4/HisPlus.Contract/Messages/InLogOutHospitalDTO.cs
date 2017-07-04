using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InLogOutHospitalDTO : DtoBase<int>
    {
        public InLogOutHospitalDTO()
        {
        }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }
    }
}
