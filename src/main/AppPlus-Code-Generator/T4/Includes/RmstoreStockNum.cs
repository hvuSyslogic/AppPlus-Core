using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class RmstoreStockNum : EntityBase<System.DateTime>
    {
        public RmstoreStockNum()
        {    
        }

        public decimal? StockNum { get; set; }
    }
}
