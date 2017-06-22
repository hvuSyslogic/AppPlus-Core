using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsItemUsageDTO : DtoBase<int>
    {
        public BsItemUsageDTO()
        {
        }

        public int ItemId { get; set; }
        public int UsageId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
