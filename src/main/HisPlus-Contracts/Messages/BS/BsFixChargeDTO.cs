using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsFixChargeDTO : DtoBase<int>
    {
        public BsFixChargeDTO()
        {
        }

        public int ItemId { get; set; }
        public int? PatTypeId { get; set; }
        public int? LocationId { get; set; }
        public decimal Totality { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
