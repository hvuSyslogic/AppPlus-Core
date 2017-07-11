using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InLogOutHospital : EntityBase<int>
    {
        public InLogOutHospital()
        {    
        }

        public int HospId { get; set; }
        public int LocationId { get; set; }
        public System.DateTime? OperTime { get; set; }
    }
}
