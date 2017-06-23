using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkCompanyCkeckDTO : DtoBase<int>
    {
        public CkCompanyCkeckDTO()
        {
        }

        public int CompanyId { get; set; }
        public System.DateTime CkeckDate { get; set; }
        public string CkeckNo { get; set; }
    }
}
