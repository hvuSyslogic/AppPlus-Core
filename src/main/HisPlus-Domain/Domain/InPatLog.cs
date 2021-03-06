using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InPatLog : EntityBase<int>
    {
        public InPatLog()
        {    
        }

        public int HospId { get; set; }
        public int LocationId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public string ActType { get; set; }
        public string Memo { get; set; }
        public int? OperId { get; set; }
        public string BedName { get; set; }
    }
}
