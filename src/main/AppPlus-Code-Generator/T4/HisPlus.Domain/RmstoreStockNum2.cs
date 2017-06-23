using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class RmstoreStockNum2 : EntityBase<System.DateTime>
    {
        public RmstoreStockNum2()
        {    
        }

        public decimal? StockNum { get; set; }
    }
}
