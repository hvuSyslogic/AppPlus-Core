using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class RmBackDetail : EntityBase<int>
    {
        public RmBackDetail()
        {    
        }

        public int BillId { get; set; }
        public int InBatchId { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public decimal DrugNum { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal StockPrice { get; set; }
        public int RecipeItemId { get; set; }
        public string Memo { get; set; }
        public decimal? BeforeStockNum { get; set; }
        public decimal? AfterStockNum { get; set; }
    }
}
