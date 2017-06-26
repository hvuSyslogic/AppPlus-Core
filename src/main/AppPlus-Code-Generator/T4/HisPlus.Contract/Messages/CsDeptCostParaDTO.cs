using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CsDeptCostParaDTO : DtoBase<int>
    {
        public CsDeptCostParaDTO()
        {
        }

        [DataMember]
        public int LocId { get; set; }

        [DataMember]
        public int CostSubjId { get; set; }

        [DataMember]
        public short? LsAppPara { get; set; }

        [DataMember]
        public string ToLocIds { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
