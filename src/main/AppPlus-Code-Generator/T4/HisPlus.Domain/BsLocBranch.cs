using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsLocBranch : EntityBase<int>
    {
        public BsLocBranch()
        {    
        }

        public int LocationId { get; set; }
        public int BranchId { get; set; }
        public string Director { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
