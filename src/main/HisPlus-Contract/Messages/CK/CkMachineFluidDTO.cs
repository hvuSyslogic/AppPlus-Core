using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkMachineFluidDTO : DtoBase<int>
    {
        public CkMachineFluidDTO()
        {
        }

        public int MachineId { get; set; }
        public int BodyFluidId { get; set; }
        public string MachineFluidCode { get; set; }
    }
}
