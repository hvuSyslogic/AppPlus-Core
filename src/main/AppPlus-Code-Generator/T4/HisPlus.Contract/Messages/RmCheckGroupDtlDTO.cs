using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RmCheckGroupDtlDTO : DtoBase<int>
    {
        public RmCheckGroupDtlDTO()
        {
        }

        [DataMember]
        public int CheckId { get; set; }

        [DataMember]
        public int GroupId { get; set; }

        [DataMember]
        public int InBatchId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public decimal CheckNum { get; set; }

        [DataMember]
        public int? OperId { get; set; }

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
