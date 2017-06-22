using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsUserRoleDTO : DtoBase<int>
    {
        public BsUserRoleDTO()
        {
        }

        public int OperId { get; set; }
        public int RoleId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
