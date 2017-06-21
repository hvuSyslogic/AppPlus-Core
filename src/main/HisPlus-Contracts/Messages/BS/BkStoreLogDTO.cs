using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BkStoreLogDTO : DtoBase<int>
    {
        public BkStoreLogDTO()
        {
        }

        public string BkRegNo { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
