using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

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
