using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkMachineResultDtlDTO : DtoBase<int>
    {
        public CkMachineResultDtlDTO()
        {
        }

        [DataMember]
        public int ResultId { get; set; }

        [DataMember]
        public int TestId { get; set; }

        [DataMember]
        public string Result { get; set; }

        [DataMember]
        public string Bench { get; set; }
    }
}
