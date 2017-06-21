using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsnotYbDTO : DtoBase<int>
    {
        public BsnotYbDTO()
        {
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public decimal? PriceIn { get; set; }
        public string F4 { get; set; }
    }
}
