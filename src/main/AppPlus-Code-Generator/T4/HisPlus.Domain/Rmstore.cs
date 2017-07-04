using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class Rmstore : EntityBase<int>
    {
        public Rmstore()
        {    
        }

        public string InBatchNo { get; set; }
        public int RoomId { get; set; }
        public int ItemId { get; set; }
        public string PNo { get; set; }
        public int UnitId { get; set; }
        public int? CompId { get; set; }
        public decimal? StockPrice { get; set; }
        public decimal? RetailPrice { get; set; }
        public decimal StockNum { get; set; }
        public decimal InstoreNum { get; set; }
        public System.DateTime? StoreDate { get; set; }
        public System.DateTime? ProduceDate { get; set; }
        public System.DateTime? LimitDate { get; set; }
        public bool IsBalance { get; set; }
    }
}
