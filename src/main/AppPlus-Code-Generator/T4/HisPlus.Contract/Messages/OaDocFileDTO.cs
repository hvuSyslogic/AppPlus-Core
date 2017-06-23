using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class OaDocFileDTO : DtoBase<int>
    {
        public OaDocFileDTO()
        {
        }

        public int? DocId { get; set; }
        public short? LsDocType { get; set; }
        public byte[] DocFile { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
