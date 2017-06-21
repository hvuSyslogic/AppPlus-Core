using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BaseTableRoleDTO : DtoBase<int>
    {
        public BaseTableRoleDTO()
        {
        }

        public int? BaseTableId { get; set; }
        public int? RoleId { get; set; }
    }
}
