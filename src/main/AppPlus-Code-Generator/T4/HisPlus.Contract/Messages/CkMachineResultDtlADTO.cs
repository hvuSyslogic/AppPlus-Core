using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkMachineResultDtlADTO : DtoBase<System.DateTime>
    {
        public CkMachineResultDtlADTO()
        {
        }

        [DataMember]
        public string Result { get; set; }

        [DataMember]
        public string Bench { get; set; }
    }
}
