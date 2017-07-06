using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class RmApplbackDtl : EntityBase<int>
    {
        public RmApplbackDtl()
        {    
        }

        public int BillId { get; set; }
        public int InBatchId { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public decimal DrugNum { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public string Memo { get; set; }
        public decimal? BeforeStockNum { get; set; }
        public decimal? AfterStockNum { get; set; }
        public int? CkDtlId { get; set; }
    }
}
