using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class TmpEmr : EntityBase<int>
    {
        public TmpEmr()
        {    
        }

        public string UseType { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short LsOpenType { get; set; }
        public int? OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int? LocationId { get; set; }
        public int OrderBy { get; set; }
        public bool IsActive { get; set; }
        public int? ParentId { get; set; }
        public int? UsageId { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
    }
}
