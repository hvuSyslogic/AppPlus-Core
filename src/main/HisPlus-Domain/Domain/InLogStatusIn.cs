using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InLogStatusIn : EntityBase<int>
    {
        public InLogStatusIn()
        {    
        }

        public int HospId { get; set; }
        public int LocationId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? LsInIllness { get; set; }
    }
}
