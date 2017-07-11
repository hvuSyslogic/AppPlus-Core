using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkMachineFluid : EntityBase<int>
    {
        public CkMachineFluid()
        {    
        }

        public int MachineId { get; set; }
        public int BodyFluidId { get; set; }
        public string MachineFluidCode { get; set; }
    }
}
