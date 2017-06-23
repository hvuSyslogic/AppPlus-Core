using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkMachineSampleDTO : DtoBase<int>
    {
        public CkMachineSampleDTO()
        {
        }

        public int LabId { get; set; }
        public string SampleNum { get; set; }
        public System.DateTime MatchDate { get; set; }
        public bool SendStatus { get; set; }
        public int? MachineId { get; set; }
        public int UserId { get; set; }
    }
}
