using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsItemYbDTO : DtoBase<int>
    {
        public BsItemYbDTO()
        {
        }

        public int ItemId { get; set; }
        public int TallyGroupId { get; set; }
        public string YbCode { get; set; }
        public string YbDesc { get; set; }
        public short LsYbType { get; set; }
        public short IconIndex { get; set; }
        public short? LsAuthstatus { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string DrugCode { get; set; }
    }
}
