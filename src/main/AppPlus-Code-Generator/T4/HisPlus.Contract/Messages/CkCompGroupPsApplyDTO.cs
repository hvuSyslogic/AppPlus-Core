using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkCompGroupPsApplyDTO : DtoBase<int>
    {
        public CkCompGroupPsApplyDTO()
        {
        }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public short XType { get; set; }

        [DataMember]
        public bool IsPre { get; set; }

        [DataMember]
        public int? ItemId { get; set; }

        [DataMember]
        public string ApplyMemo { get; set; }

        [DataMember]
        public string Summary { get; set; }

        [DataMember]
        public string Diagnose { get; set; }

        [DataMember]
        public int? CompGroupId { get; set; }
    }
}
