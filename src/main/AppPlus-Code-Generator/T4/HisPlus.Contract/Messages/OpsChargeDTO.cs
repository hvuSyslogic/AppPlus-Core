using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OpsChargeDTO : DtoBase<int>
    {
        public OpsChargeDTO()
        {
        }

        [DataMember]
        public int ApplyId { get; set; }

        [DataMember]
        public int ListNum { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public string Remark { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public bool IsTally { get; set; }

        [DataMember]
        public decimal? Before { get; set; }

        [DataMember]
        public decimal? Progress { get; set; }

        [DataMember]
        public decimal? After { get; set; }
    }
}
