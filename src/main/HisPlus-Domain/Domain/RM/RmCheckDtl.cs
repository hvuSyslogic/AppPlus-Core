using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class RmCheckDtl : EntityBase<int>
    {
        public RmCheckDtl()
        {    
        }

        public int CheckId { get; set; }
        public int InBatchId { get; set; }
        public int ItemId { get; set; }
        public int? CompId { get; set; }
        public int UnitId { get; set; }
        public decimal BalanceNum { get; set; }
        public decimal StockNum { get; set; }
        public decimal InstoreNum { get; set; }
        public decimal CheckNum { get; set; }
        public int? OperId { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public string Compare { get; set; }
        public bool Balance { get; set; }
        public bool IsAdjust { get; set; }
        public decimal ApplyIn { get; set; }
        public decimal MzBackIn { get; set; }
        public decimal ZyBackIn { get; set; }
        public decimal MoveIn { get; set; }
        public decimal OtherIn { get; set; }
        public decimal MoveOut { get; set; }
        public decimal MzOut { get; set; }
        public decimal ZyOut { get; set; }
        public decimal LoseOut { get; set; }
        public decimal BackOut { get; set; }
        public decimal OtherOut { get; set; }
        public decimal AdjustAmouUp { get; set; }
        public decimal AdjustAmouDn { get; set; }
        public decimal RecipeOut { get; set; }
        public decimal KsBackIn { get; set; }
        public decimal KsOut { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
    }
}
