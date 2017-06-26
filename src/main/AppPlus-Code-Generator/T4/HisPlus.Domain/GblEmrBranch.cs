using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
