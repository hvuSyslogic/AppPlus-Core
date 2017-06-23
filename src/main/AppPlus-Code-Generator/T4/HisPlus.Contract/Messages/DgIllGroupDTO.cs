using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class DgIllGroupDTO : DtoBase<int>
    {
        public DgIllGroupDTO()
        {
        }

        public int? IcdId { get; set; }
        public string GroupDesc { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
