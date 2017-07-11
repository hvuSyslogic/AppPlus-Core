using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class TrScheLine : EntityBase<int>
    {
        public TrScheLine()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int? LocationId { get; set; }
        public string Memo { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public int? LabelId { get; set; }
        public System.DateTime? StartTime { get; set; }
        public System.DateTime? EndTime { get; set; }
    }
}
