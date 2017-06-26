using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class HuCheckSum : EntityBase<int>
    {
        public HuCheckSum()
        {    
        }

        public int BillId { get; set; }
        public string SumFor { get; set; }
        public decimal BuyIn { get; set; }
        public decimal BackIn { get; set; }
        public decimal PyIn { get; set; }
        public decimal OtherIn { get; set; }
        public decimal DeptOut { get; set; }
        public decimal SaleOut { get; set; }
        public decimal BackOut { get; set; }
        public decimal PkOut { get; set; }
        public decimal LoseOut { get; set; }
        public decimal AdjustAmouUp { get; set; }
        public decimal AdjustAmouDn { get; set; }
        public decimal CheckAmou { get; set; }
        public decimal BalanceAmou { get; set; }
        public decimal TotalPrice { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
