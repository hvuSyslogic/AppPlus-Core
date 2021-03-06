using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblPatientMenu : EntityBase<int>
    {
        public GblPatientMenu()
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
        public short IconIndex { get; set; }
        public bool? IsAuth { get; set; }
        public bool? IsPrint { get; set; }
        public string SearchConfig { get; set; }
        public string FileEmt { get; set; }
    }
}
