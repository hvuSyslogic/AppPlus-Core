using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class RmstoresBak0531 : EntityBase<int>
    {
        public RmstoresBak0531()
        {    
        }

        public string PNo { get; set; }
        public int? CompId { get; set; }
        public decimal? StockPrice { get; set; }
        public decimal? RetailPrice { get; set; }
        public System.DateTime? StoreDate { get; set; }
        public System.DateTime? ProduceDate { get; set; }
        public System.DateTime? LimitDate { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
