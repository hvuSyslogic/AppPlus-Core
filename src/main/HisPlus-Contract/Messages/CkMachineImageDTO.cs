using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkMachineImageDTO : DtoBase<int>
    {
        public CkMachineImageDTO()
        {
        }

        [DataMember]
        public int LabId { get; set; }

        [DataMember]
        public string SampleNum { get; set; }

        [DataMember]
        public int MachineId { get; set; }

        [DataMember]
        public byte[] LabImage { get; set; }

        [DataMember]
        public string ImageType { get; set; }

        [DataMember]
        public bool IsDisplay { get; set; }

        [DataMember]
        public short OrderBy { get; set; }
    }
}
