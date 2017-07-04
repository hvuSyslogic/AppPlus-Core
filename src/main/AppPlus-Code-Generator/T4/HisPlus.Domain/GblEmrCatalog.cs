using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblEmrCatalog : EntityBase<int>
    {
        public GblEmrCatalog()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
        public string InfoPathFile { get; set; }
        public short? LsCompareType { get; set; }
        public short? AheadHours { get; set; }
    }
}
