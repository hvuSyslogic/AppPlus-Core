using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
