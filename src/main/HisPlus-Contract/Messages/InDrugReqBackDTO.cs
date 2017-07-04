using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InDrugReqBackDTO : DtoBase<int>
    {
        public InDrugReqBackDTO()
        {
        }

        [DataMember]
        public int ReqDtlId { get; set; }

        [DataMember]
        public short ListNum { get; set; }

        [DataMember]
        public decimal Totality { get; set; }

        [DataMember]
        public int UnitId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public bool IsBack { get; set; }

        [DataMember]
        public int? DetailId { get; set; }

        [DataMember]
        public System.DateTime? BackTime { get; set; }

        [DataMember]
        public int? AdviceId { get; set; }

        [DataMember]
        public short? LsMarkType { get; set; }

        [DataMember]
        public bool? IsPrint { get; set; }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public int? RequestId { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public int? BackOperId { get; set; }
    }
}
