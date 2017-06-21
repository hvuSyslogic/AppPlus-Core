using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsPriceAddDTO : DtoBase<int>
    {
        public BsPriceAddDTO()
        {
        }

        public decimal PriceLow { get; set; }
        public decimal? PriceHigh { get; set; }
        public decimal? AddPercent { get; set; }
        public decimal? AddPrice { get; set; }
        public string FeeIds { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
