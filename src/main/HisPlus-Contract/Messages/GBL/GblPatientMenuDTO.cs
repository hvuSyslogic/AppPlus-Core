using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblPatientMenuDTO : DtoBase<int>
    {
        public GblPatientMenuDTO()
        {
        }

        public short LsType { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public bool IsTitle { get; set; }
        public string FormName { get; set; }
        public string TableName { get; set; }
        public bool IsForNew { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public bool? IsAuth { get; set; }
        public bool? IsPrint { get; set; }
        public string SearchConfig { get; set; }
    }
}
