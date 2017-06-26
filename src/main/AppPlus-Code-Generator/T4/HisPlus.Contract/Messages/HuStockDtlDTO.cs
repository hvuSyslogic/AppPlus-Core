using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class HuStockDtlDTO : DtoBase<int>
    {
        public HuStockDtlDTO()
        {
        }

        [DataMember]
        public int BillId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public string InBatchNo { get; set; }

        [DataMember]
        public string PNo { get; set; }

        [DataMember]
        public int UnitId { get; set; }

        [DataMember]
        public decimal DrugNum { get; set; }

        [DataMember]
        public decimal StockPrice { get; set; }

        [DataMember]
        public decimal RetailPrice { get; set; }

        [DataMember]
        public System.DateTime? ProduceDate { get; set; }

        [DataMember]
        public System.DateTime? LimitDate { get; set; }

        [DataMember]
        public bool IsBid { get; set; }

        [DataMember]
        public string VoucherNo { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public int? ProAreaId { get; set; }

        [DataMember]
        public int? ManuId { get; set; }

        [DataMember]
        public string PassNo { get; set; }

        [DataMember]
        public decimal? PriceHighLine { get; set; }
    }
}
