using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

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
    }
}
