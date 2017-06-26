using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OtBidDtlDTO : DtoBase<int>
    {
        public OtBidDtlDTO()
        {
        }

        [DataMember]
        public int? BidId { get; set; }

        [DataMember]
        public string RoundNTime { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public int ExpOperId { get; set; }

        [DataMember]
        public byte? Point { get; set; }

        [DataMember]
        public bool? IsPass { get; set; }

        [DataMember]
        public string Memo { get; set; }

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
