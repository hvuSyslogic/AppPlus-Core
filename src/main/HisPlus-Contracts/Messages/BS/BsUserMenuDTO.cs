using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsUserMenuDTO : DtoBase<int>
    {
        public BsUserMenuDTO()
        {
        }

        public int OperId { get; set; }
        public int? MenuId { get; set; }
        public int? OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
