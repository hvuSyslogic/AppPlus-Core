using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsItemYbTipDTO : DtoBase<int>
    {
        public BsItemYbTipDTO()
        {
        }

        public int ItemId { get; set; }
        public int? PatTypeId { get; set; }
        public int? TallyGroupId { get; set; }
        public int? IcdId { get; set; }
        public string IllDesc { get; set; }
        public string Tips { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
