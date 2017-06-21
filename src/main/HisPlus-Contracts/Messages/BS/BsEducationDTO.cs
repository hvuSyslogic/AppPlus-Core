using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsEducationDTO : DtoBase<int>
    {
        public BsEducationDTO()
        {
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string GroupMain { get; set; }
        public string GroupSub { get; set; }
        public string Content { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
