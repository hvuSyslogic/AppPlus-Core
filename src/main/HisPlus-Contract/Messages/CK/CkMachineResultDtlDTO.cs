using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkMachineResultDtlDTO : DtoBase<int>
    {
        public CkMachineResultDtlDTO()
        {
        }

        public int ResultId { get; set; }
        public int TestId { get; set; }
        public string Result { get; set; }
        public string Bench { get; set; }
    }
}
