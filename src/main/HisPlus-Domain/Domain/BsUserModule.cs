using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsUserModule : EntityBase<int>
    {
        public BsUserModule()
        {    
        }

        public int OperId { get; set; }
        public int ModuleId { get; set; }
        public short IconIndex { get; set; }
    }
}
