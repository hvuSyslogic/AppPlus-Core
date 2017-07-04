using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblEmrQcItem : EntityBase<int>
    {
        public GblEmrQcItem()
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
        public short IconIndex { get; set; }
        public short? FullPoint { get; set; }
        public short? FailPoint { get; set; }
        public short? LsImportant { get; set; }
    }
}
