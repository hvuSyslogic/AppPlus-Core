using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkMachineFluidDTO : DtoBase<int>
    {
        public CkMachineFluidDTO()
        {
        }

        [DataMember]
        public int MachineId { get; set; }

        [DataMember]
        public int BodyFluidId { get; set; }

        [DataMember]
        public string MachineFluidCode { get; set; }
    }
}
