using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class RmZyOutDtl : EntityBase<int>
    {
        public RmZyOutDtl()
        {    
        }

        public int BillId { get; set; }
        public int? InBatchId { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public decimal DrugNum { get; set; }
        public decimal BackNum { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal StockPrice { get; set; }
        public int? ReqItemId { get; set; }
        public int? RecipeItemId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
