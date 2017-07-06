using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsUserMenu : EntityBase<int>
    {
        public BsUserMenu()
        {    
        }

        public int OperId { get; set; }
        public int? MenuId { get; set; }
        public int? OrderBy { get; set; }
        public short IconIndex { get; set; }
    }
}
