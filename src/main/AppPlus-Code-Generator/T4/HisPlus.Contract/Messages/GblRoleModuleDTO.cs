using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblRoleModuleDTO : DtoBase<int>
    {
        public GblRoleModuleDTO()
        {
        }

        public int RoleId { get; set; }
        public int ModuleId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
