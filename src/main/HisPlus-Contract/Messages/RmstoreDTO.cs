using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RmstoreDTO : DtoBase<int>
    {
        public RmstoreDTO()
        {
        }

        [DataMember]
        public string InBatchNo { get; set; }

        [DataMember]
        public int RoomId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public string PNo { get; set; }

        [DataMember]
        public int UnitId { get; set; }

        [DataMember]
        public int? CompId { get; set; }

        [DataMember]
        public decimal? StockPrice { get; set; }

        [DataMember]
        public decimal? RetailPrice { get; set; }

        [DataMember]
        public decimal StockNum { get; set; }

        [DataMember]
        public decimal InstoreNum { get; set; }

        [DataMember]
        public System.DateTime? StoreDate { get; set; }

        [DataMember]
        public System.DateTime? ProduceDate { get; set; }

        [DataMember]
        public System.DateTime? LimitDate { get; set; }

        [DataMember]
        public bool IsBalance { get; set; }

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
