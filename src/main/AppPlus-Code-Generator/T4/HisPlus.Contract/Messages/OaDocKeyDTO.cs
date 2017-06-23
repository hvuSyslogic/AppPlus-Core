using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class OaDocKeyDTO : DtoBase<int>
    {
        public OaDocKeyDTO()
        {
        }

        public int? DocId { get; set; }
        public string WordKey { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
