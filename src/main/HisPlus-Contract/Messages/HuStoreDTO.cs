using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class HuStoreDTO : DtoBase<int>
    {
        public HuStoreDTO()
        {
        }

        [DataMember]
        public string InBatchNo { get; set; }

        [DataMember]
        public int HouseId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public string PNo { get; set; }

        [DataMember]
        public int UnitId { get; set; }

        [DataMember]
        public int? CompId { get; set; }

        [DataMember]
        public decimal StockNum { get; set; }

        [DataMember]
        public decimal InstoreNum { get; set; }

        [DataMember]
        public decimal StockPrice { get; set; }

        [DataMember]
        public decimal RetailPrice { get; set; }

        [DataMember]
        public System.DateTime StoreDate { get; set; }

        [DataMember]
        public System.DateTime? ProduceDate { get; set; }

        [DataMember]
        public System.DateTime? LimitDate { get; set; }

        [DataMember]
        public bool IsBalance { get; set; }

        [DataMember]
        public bool IsNewin { get; set; }

        [DataMember]
        public bool IsBid { get; set; }
    }
}
