using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkCompanyGroup : EntityBase<int>
    {
        public CkCompanyGroup()
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
