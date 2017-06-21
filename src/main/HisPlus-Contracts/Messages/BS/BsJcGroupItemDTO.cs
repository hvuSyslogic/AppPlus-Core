using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsJcGroupItemDTO : DtoBase<int>
    {
        public BsJcGroupItemDTO()
        {
        }

        public int GroupId { get; set; }
        public int ItemId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
