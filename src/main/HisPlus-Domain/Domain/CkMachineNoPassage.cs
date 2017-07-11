using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkMachineNoPassage : EntityBase<int>
    {
        public CkMachineNoPassage()
        {    
        }

        public int MachineId { get; set; }
        public string PassAgeNum { get; set; }
        public string TestResuslt { get; set; }
        public System.DateTime? ResultDate { get; set; }
    }
}
