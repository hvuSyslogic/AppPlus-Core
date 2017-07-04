using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsOpsItem : EntityBase<int>
    {
        public BsOpsItem()
        {    
        }

        public int OpsItem { get; set; }
        public int ItemId { get; set; }
        public short IconIndex { get; set; }
    }
}
