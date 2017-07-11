using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CkCompanyMan : EntityBase<int>
    {
        public CkCompanyMan()
        {    
        }

        public int CompanyGroupId { get; set; }
        public int PatId { get; set; }
    }
}
