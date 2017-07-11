using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkQcControl : EntityBase<int>
    {
        public CkQcControl()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int MachineId { get; set; }
    }
}
