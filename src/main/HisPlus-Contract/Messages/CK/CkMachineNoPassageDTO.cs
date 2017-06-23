using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkMachineNoPassageDTO : DtoBase<int>
    {
        public CkMachineNoPassageDTO()
        {
        }

        public int MachineId { get; set; }
        public string PassAgeNum { get; set; }
        public string TestResuslt { get; set; }
        public System.DateTime? ResultDate { get; set; }
    }
}
