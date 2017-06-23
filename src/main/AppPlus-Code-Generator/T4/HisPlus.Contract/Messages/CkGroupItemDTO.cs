using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkGroupItemDTO : DtoBase<int>
    {
        public CkGroupItemDTO()
        {
        }

        public int CompanyGroupId { get; set; }
        public int TestId { get; set; }
        public int ParentId { get; set; }
        public string ItemId { get; set; }
        public string AppId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
