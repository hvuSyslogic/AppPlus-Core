using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblEmrBranch : EntityBase<int>
    {
        public GblEmrBranch()
        {    
        }

        public int? BranchId { get; set; }
        public int CatalogId { get; set; }
        public string XsdFile { get; set; }
    }
}
