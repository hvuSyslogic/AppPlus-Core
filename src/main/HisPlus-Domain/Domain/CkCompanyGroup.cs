using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkCompanyGroup : EntityBase<int>
    {
        public CkCompanyGroup()
        {    
        }

        public int CompanyId { get; set; }
        public int GroupId { get; set; }
    }
}
