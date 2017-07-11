using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InChangeBedDTO : DtoBase<int>
    {
        public InChangeBedDTO()
        {
        }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public short LsLocal { get; set; }

        [DataMember]
        public System.DateTime ChgTime { get; set; }

        [DataMember]
        public int PreBed { get; set; }

        [DataMember]
        public int PostBed { get; set; }

        [DataMember]
        public string Reason { get; set; }

        [DataMember]
        public int DoctorId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }
    }
}
