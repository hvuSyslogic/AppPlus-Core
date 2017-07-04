using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblRoleModule : EntityBase<int>
    {
        public GblRoleModule()
        {    
        }

        public int RoleId { get; set; }
        public int ModuleId { get; set; }
        public short IconIndex { get; set; }
    }
}
