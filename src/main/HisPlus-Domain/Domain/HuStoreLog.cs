using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class HuStoreLog : EntityBase<int>
    {
        public HuStoreLog()
        {    
        }

        public System.DateTime HappenTime { get; set; }
        public int HouseId { get; set; }
        public int ItemId { get; set; }
        public int InBatchId { get; set; }
        public decimal BeforeStockNum { get; set; }
        public decimal HappenNum { get; set; }
        public decimal AfterStockNum { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal StockPrice { get; set; }
        public int UnitId { get; set; }
        public string BillNo { get; set; }
        public short LsActType { get; set; }
        public string Memo { get; set; }
        public decimal? BeforeStockNumSum { get; set; }
        public decimal? AfterStockNumSum { get; set; }
    }
}
