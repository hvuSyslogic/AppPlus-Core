using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblFunDemoDTO : DtoBase<int>
    {
        public GblFunDemoDTO()
        {
        }

        public string Purpose { get; set; }
        public int? FuntionId { get; set; }
        public string Memo { get; set; }
        public int? OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
