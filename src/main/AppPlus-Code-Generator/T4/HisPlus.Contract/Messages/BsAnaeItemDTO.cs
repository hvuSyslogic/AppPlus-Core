using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsAnaeItemDTO : DtoBase<int>
    {
        public BsAnaeItemDTO()
        {
        }

        public int AnaeId { get; set; }
        public int ItemId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
