using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class HuCheckDtl : EntityBase<int>
    {
        public HuCheckDtl()
        {    
        }

        public int BillId { get; set; }
        public int InBatchId { get; set; }
        public int ItemId { get; set; }
        public int? CompId { get; set; }
        public int UnitId { get; set; }
        public decimal BalanceNum { get; set; }
        public decimal StcokNum { get; set; }
        public decimal InstoreNum { get; set; }
        public decimal CheckNum { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public string Compare { get; set; }
        public bool IsBalance { get; set; }
        public bool IsAdjust { get; set; }
        public decimal BuyIn { get; set; }
        public decimal BackIn { get; set; }
        public decimal OtherIn { get; set; }
        public decimal DeptOut { get; set; }
        public decimal SaleOut { get; set; }
        public decimal BackOut { get; set; }
        public decimal LoseOut { get; set; }
        public decimal AdjustAmouUp { get; set; }
        public decimal AdjustAmouDn { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
