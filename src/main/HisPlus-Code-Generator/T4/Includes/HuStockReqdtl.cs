using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class HuStockReqdtl : EntityBase<int>
    {
        public HuStockReqdtl()
        {    
        }

        public int BillId { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public decimal DrugNum { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
