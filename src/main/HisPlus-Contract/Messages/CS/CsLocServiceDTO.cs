using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CsLocServiceDTO : DtoBase<int>
    {
        public CsLocServiceDTO()
        {
        }

        public int LocId { get; set; }
        public int LogisticServeId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
