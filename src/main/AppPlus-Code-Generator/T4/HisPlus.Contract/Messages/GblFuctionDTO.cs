using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblFuctionDTO : DtoBase<int>
    {
        public GblFuctionDTO()
        {
        }

        public int? MenuId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Memo { get; set; }
        public bool? IsTest { get; set; }
        public short? LsClass { get; set; }
        public int OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Code { get; set; }
    }
}
