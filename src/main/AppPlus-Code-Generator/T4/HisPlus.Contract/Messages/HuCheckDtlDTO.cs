using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class HuCheckDtlDTO : DtoBase<int>
    {
        public HuCheckDtlDTO()
        {
        }

        [DataMember]
        public int BillId { get; set; }

        [DataMember]
        public int InBatchId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public int? CompId { get; set; }

        [DataMember]
        public int UnitId { get; set; }

        [DataMember]
        public decimal BalanceNum { get; set; }

        [DataMember]
        public decimal StcokNum { get; set; }

        [DataMember]
        public decimal InstoreNum { get; set; }

        [DataMember]
        public decimal CheckNum { get; set; }

        [DataMember]
        public decimal StockPrice { get; set; }

        [DataMember]
        public decimal RetailPrice { get; set; }

        [DataMember]
        public string Compare { get; set; }

        [DataMember]
        public bool IsBalance { get; set; }

        [DataMember]
        public bool IsAdjust { get; set; }

        [DataMember]
        public decimal BuyIn { get; set; }

        [DataMember]
        public decimal BackIn { get; set; }

        [DataMember]
        public decimal OtherIn { get; set; }

        [DataMember]
        public decimal DeptOut { get; set; }

        [DataMember]
        public decimal SaleOut { get; set; }

        [DataMember]
        public decimal BackOut { get; set; }

        [DataMember]
        public decimal LoseOut { get; set; }

        [DataMember]
        public decimal AdjustAmouUp { get; set; }

        [DataMember]
        public decimal AdjustAmouDn { get; set; }
    }
}
