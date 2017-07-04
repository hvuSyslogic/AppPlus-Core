using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsBpPatientGroupDTO : DtoBase<int>
    {
        public BsBpPatientGroupDTO()
        {
        }

        [DataMember]
        public string PatientGroup { get; set; }

        [DataMember]
        public int? BpIllId { get; set; }

        [DataMember]
        public int? OrderBy { get; set; }
    }
}
