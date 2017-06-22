using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsPatTypeLimitDTO : DtoBase<int>
    {
        public BsPatTypeLimitDTO()
        {
        }

        public int PatTypeId { get; set; }
        public int DocLevId { get; set; }
        public int? LimitGroupId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
