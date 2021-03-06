using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CkMachinePassage : EntityBase<int>
    {
        public CkMachinePassage()
        {    
        }

        public int MachineId { get; set; }
        public int TestId { get; set; }
        public string PassAgeNum { get; set; }
        public decimal Modulus { get; set; }
        public bool IsQc { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
