using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class HuOtherInDtlDTO : DtoBase<int>
    {
        public HuOtherInDtlDTO()
        {
        }

        [DataMember]
        public int BillId { get; set; }

        [DataMember]
        public string InBatchNo { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public string PNo { get; set; }

        [DataMember]
        public int UnitId { get; set; }

        [DataMember]
        public int? CompId { get; set; }

        [DataMember]
        public decimal DrugNum { get; set; }

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
    }
}
