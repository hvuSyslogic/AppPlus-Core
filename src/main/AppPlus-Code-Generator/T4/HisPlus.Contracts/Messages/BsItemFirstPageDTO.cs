using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsItemFirstPageDTO : DtoBase<int>
    {
        public BsItemFirstPageDTO()
        {
        }

        public int ItemId { get; set; }
        public int? PsFeeId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
