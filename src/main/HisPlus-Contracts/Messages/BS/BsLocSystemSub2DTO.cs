using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsLocSystemSub2DTO : DtoBase<int>
    {
        public BsLocSystemSub2DTO()
        {
        }

        public int SubId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
