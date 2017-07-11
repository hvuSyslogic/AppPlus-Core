using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkMachineNoPassageDTO : DtoBase<int>
    {
        public CkMachineNoPassageDTO()
        {
        }

        [DataMember]
        public int MachineId { get; set; }

        [DataMember]
        public string PassAgeNum { get; set; }

        [DataMember]
        public string TestResuslt { get; set; }

        [DataMember]
        public System.DateTime? ResultDate { get; set; }
    }
}
