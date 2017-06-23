using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkCompanyGroupDTO : DtoBase<int>
    {
        public CkCompanyGroupDTO()
        {
        }

        public int CompanyId { get; set; }
        public int GroupId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
