using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RmZyOutDtlDTO : DtoBase<int>
    {
        public RmZyOutDtlDTO()
        {
        }

        [DataMember]
        public int BillId { get; set; }

        [DataMember]
        public int? InBatchId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public int UnitId { get; set; }

        [DataMember]
        public decimal DrugNum { get; set; }

        [DataMember]
        public decimal BackNum { get; set; }

        [DataMember]
        public decimal RetailPrice { get; set; }

        [DataMember]
        public decimal StockPrice { get; set; }

        [DataMember]
        public int? ReqItemId { get; set; }

        [DataMember]
        public int? RecipeItemId { get; set; }

        [DataMember]
        public decimal? BeforeStockNum { get; set; }

        [DataMember]
        public decimal? AfterStockNum { get; set; }
    }
}
