using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsXdGroupDtlDTO : DtoBase<int>
    {
        public BsXdGroupDtlDTO()
        {
        }

        public int GroupId { get; set; }
        public int XdRpId { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short LsOpenType { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int LocationId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
