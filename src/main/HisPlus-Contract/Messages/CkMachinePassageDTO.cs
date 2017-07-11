using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkMachinePassageDTO : DtoBase<int>
    {
        public CkMachinePassageDTO()
        {
        }

        [DataMember]
        public int MachineId { get; set; }

        [DataMember]
        public int TestId { get; set; }

        [DataMember]
        public string PassAgeNum { get; set; }

        [DataMember]
        public decimal Modulus { get; set; }

        [DataMember]
        public bool IsQc { get; set; }
    }
}
