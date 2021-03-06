using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class HuStockDtl : EntityBase<int>
    {
        public HuStockDtl()
        {    
        }

        public int BillId { get; set; }
        public int ItemId { get; set; }
        public string InBatchNo { get; set; }
        public string PNo { get; set; }
        public int UnitId { get; set; }
        public decimal DrugNum { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public System.DateTime? ProduceDate { get; set; }
        public System.DateTime? LimitDate { get; set; }
        public bool IsBid { get; set; }
        public string VoucherNo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? ProAreaId { get; set; }
        public int? ManuId { get; set; }
        public string PassNo { get; set; }
        public decimal? PriceHighLine { get; set; }
    }
}
