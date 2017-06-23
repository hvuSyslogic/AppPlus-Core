using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class RmstoreStockNumDTO : DtoBase<System.DateTime>
    {
        public RmstoreStockNumDTO()
        {
        }

        public decimal? StockNum { get; set; }
    }
}
