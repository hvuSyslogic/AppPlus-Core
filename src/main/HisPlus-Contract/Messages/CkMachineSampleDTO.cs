using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkMachineSampleDTO : DtoBase<int>
    {
        public CkMachineSampleDTO()
        {
        }

        [DataMember]
        public int LabId { get; set; }

        [DataMember]
        public string SampleNum { get; set; }

        [DataMember]
        public System.DateTime MatchDate { get; set; }

        [DataMember]
        public bool SendStatus { get; set; }

        [DataMember]
        public int? MachineId { get; set; }

        [DataMember]
        public int UserId { get; set; }
    }
}
