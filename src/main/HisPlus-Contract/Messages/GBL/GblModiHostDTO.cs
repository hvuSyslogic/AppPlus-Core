using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblModiHostDTO : DtoBase<int>
    {
        public GblModiHostDTO()
        {
        }

        public string BaseTable { get; set; }
        public string Hostname { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
