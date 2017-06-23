using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class OaDocReaderDTO : DtoBase<int>
    {
        public OaDocReaderDTO()
        {
        }

        public int? DocId { get; set; }
        public int? AllowOperId { get; set; }
        public System.DateTime? ExpireTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
