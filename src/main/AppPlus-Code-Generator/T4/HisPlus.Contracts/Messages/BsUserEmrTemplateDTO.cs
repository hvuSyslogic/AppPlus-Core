using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsUserEmrTemplateDTO : DtoBase<int>
    {
        public BsUserEmrTemplateDTO()
        {
        }

        public int OperId { get; set; }
        public int CatalogId { get; set; }
        public string Name { get; set; }
        public string TemplateFile { get; set; }
        public bool IsDefault { get; set; }
        public short OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public short? LsOpenType { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? LocationId { get; set; }
        public bool? IsActive { get; set; }
    }
}
