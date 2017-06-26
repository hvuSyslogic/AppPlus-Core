using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkMachineResultDTO : DtoBase<int>
    {
        public CkMachineResultDTO()
        {
        }

        [DataMember]
        public int LabId { get; set; }

        [DataMember]
        public string SampleNum { get; set; }

        [DataMember]
        public System.DateTime TestDate { get; set; }

        [DataMember]
        public int MachineId { get; set; }

        [DataMember]
        public int TestTypeId { get; set; }
    }
}
