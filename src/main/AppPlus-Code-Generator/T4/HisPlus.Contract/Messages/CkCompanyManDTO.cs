using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkCompanyManDTO : DtoBase<int>
    {
        public CkCompanyManDTO()
        {
        }

        public int CompanyGroupId { get; set; }
        public int PatId { get; set; }
    }
}
