using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblEmrQcGroup : EntityBase<int>
    {
        public GblEmrQcGroup()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public short? Point { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
        public string Memo { get; set; }
    }
}
