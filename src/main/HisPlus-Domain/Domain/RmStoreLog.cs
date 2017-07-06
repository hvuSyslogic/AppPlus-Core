using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class RmStoreLog : EntityBase<int>
    {
        public RmStoreLog()
        {    
        }

        public System.DateTime HappenTime { get; set; }
        public int RoomId { get; set; }
        public int ItemId { get; set; }
        public int InBatchId { get; set; }
        public decimal BeforeStockNum { get; set; }
        public decimal HappenNum { get; set; }
        public decimal? StockPrice { get; set; }
        public decimal? RetailPrice { get; set; }
        public int UnitId { get; set; }
        public string BillNo { get; set; }
        public short LsActType { get; set; }
        public string Memo { get; set; }
        public decimal AfterStockNum { get; set; }
        public decimal? BeforeStockTotalNum { get; set; }
        public decimal? AfterStockTotalNum { get; set; }
        public int? LocationId { get; set; }
        public int? InOuPatId { get; set; }
        public int? OutDtlId { get; set; }
        public decimal? Price { get; set; }
    }
}
