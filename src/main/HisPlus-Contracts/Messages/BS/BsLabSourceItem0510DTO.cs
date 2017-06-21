using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsLabSourceItem0510DTO : DtoBase<int>
    {
        public BsLabSourceItem0510DTO()
        {
        }

        public int? TubeTypeId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
