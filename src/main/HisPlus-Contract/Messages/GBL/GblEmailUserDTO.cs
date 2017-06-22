using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblEmailUserDTO : DtoBase<int>
    {
        public GblEmailUserDTO()
        {
        }

        public int EmailId { get; set; }
        public int OperId { get; set; }
        public bool? IsRead { get; set; }
        public System.DateTime? ReadTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
