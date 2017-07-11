using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsItemUsage : EntityBase<int>
    {
        public BsItemUsage()
        {    
        }

        public int ItemId { get; set; }
        public int UsageId { get; set; }
        public short IconIndex { get; set; }
    }
}
