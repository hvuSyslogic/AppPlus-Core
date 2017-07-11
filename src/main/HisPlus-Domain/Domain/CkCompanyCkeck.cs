using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkCompanyCkeck : EntityBase<int>
    {
        public CkCompanyCkeck()
        {    
        }

        public int CompanyId { get; set; }
        public System.DateTime CkeckDate { get; set; }
        public string CkeckNo { get; set; }
    }
}
