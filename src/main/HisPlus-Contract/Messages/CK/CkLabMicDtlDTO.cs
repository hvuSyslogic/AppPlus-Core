using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkLabMicDtlDTO : DtoBase<int>
    {
        public CkLabMicDtlDTO()
        {
        }

        public int MicId { get; set; }
        public int? DrugId { get; set; }
        public string Result { get; set; }
        public string LsMic { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
