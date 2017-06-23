using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class RmstoreStockNum2DTO : DtoBase<System.DateTime>
    {
        public RmstoreStockNum2DTO()
        {
        }

        public decimal? StockNum { get; set; }
    }
}
