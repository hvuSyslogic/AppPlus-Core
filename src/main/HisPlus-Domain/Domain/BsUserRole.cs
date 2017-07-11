using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsUserRole : EntityBase<int>
    {
        public BsUserRole()
        {    
        }

        public int OperId { get; set; }
        public int RoleId { get; set; }
        public short IconIndex { get; set; }
    }
}
