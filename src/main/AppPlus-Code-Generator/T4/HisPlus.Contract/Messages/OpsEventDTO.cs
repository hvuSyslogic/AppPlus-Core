using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class OpsEventDTO : DtoBase<int>
    {
        public OpsEventDTO()
        {
        }

        public int? ItemId { get; set; }
        public int? UnitTakeId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? UsageId { get; set; }
    }
}
