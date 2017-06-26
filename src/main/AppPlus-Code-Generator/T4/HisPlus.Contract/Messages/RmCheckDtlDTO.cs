using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RmCheckDtlDTO : DtoBase<int>
    {
        public RmCheckDtlDTO()
        {
        }

        [DataMember]
        public int CheckId { get; set; }

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
        public decimal StockNum { get; set; }

        [DataMember]
        public decimal InstoreNum { get; set; }

        [DataMember]
        public decimal CheckNum { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public decimal StockPrice { get; set; }

        [DataMember]
        public decimal RetailPrice { get; set; }

        [DataMember]
        public string Compare { get; set; }

        [DataMember]
        public bool Balance { get; set; }

        [DataMember]
        public bool IsAdjust { get; set; }

        [DataMember]
        public decimal ApplyIn { get; set; }

        [DataMember]
        public decimal MzBackIn { get; set; }

        [DataMember]
        public decimal ZyBackIn { get; set; }

        [DataMember]
        public decimal MoveIn { get; set; }

        [DataMember]
        public decimal OtherIn { get; set; }

        [DataMember]
        public decimal MoveOut { get; set; }

        [DataMember]
        public decimal MzOut { get; set; }

        [DataMember]
        public decimal ZyOut { get; set; }

        [DataMember]
        public decimal LoseOut { get; set; }

        [DataMember]
        public decimal BackOut { get; set; }

        [DataMember]
        public decimal OtherOut { get; set; }

        [DataMember]
        public decimal AdjustAmouUp { get; set; }

        [DataMember]
        public decimal AdjustAmouDn { get; set; }

        [DataMember]
        public decimal RecipeOut { get; set; }

        [DataMember]
        public decimal KsBackIn { get; set; }

        [DataMember]
        public decimal KsOut { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public string F5 { get; set; }

        [DataMember]
        public string F6 { get; set; }

        [DataMember]
        public string F7 { get; set; }
    }
}
