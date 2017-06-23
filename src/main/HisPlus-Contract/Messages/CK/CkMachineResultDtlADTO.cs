using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkMachineResultDtlADTO : DtoBase<System.DateTime>
    {
        public CkMachineResultDtlADTO()
        {
        }

        public string Result { get; set; }
        public string Bench { get; set; }
    }
}
