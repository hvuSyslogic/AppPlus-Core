using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

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
