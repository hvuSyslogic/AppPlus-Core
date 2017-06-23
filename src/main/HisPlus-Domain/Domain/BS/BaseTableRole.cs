using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BaseTableRole : EntityBase<int>
    {
        public BaseTableRole()
        {    
        }

        public int? BaseTableId { get; set; }
        public int? RoleId { get; set; }
    }
}
