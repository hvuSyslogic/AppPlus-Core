using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
