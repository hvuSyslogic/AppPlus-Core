using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsMessageTemplate : EntityBase<int>
    {
        public BsMessageTemplate()
        {    
        }

        public string Name { get; set; }
        public string Contents { get; set; }
        public int? ParentId { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsActive { get; set; }
    }
}
