using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class HuBackDtl : EntityBase<int>
    {
        public HuBackDtl()
        {    
        }

        public int BillId { get; set; }
        public int InBatchId { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public decimal DrugNum { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal StockPrice { get; set; }
        public string Memo { get; set; }
        public string VoucherNo { get; set; }
        public bool IsMargin { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
