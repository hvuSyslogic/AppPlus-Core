using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblEmrQcItemDTO : DtoBase<int>
    {
        public GblEmrQcItemDTO()
        {
        }

        public int GroupId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Standard { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public short? FullPoint { get; set; }
        public short? FailPoint { get; set; }
        public short? LsImportant { get; set; }
    }
}