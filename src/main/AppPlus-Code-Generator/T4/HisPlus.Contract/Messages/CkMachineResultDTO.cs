using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkMachineResultDTO : DtoBase<int>
    {
        public CkMachineResultDTO()
        {
        }

        public int LabId { get; set; }
        public string SampleNum { get; set; }
        public System.DateTime TestDate { get; set; }
        public int MachineId { get; set; }
        public int TestTypeId { get; set; }
    }
}
