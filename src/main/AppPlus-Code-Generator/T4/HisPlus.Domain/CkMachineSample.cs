using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkMachineSample : EntityBase<int>
    {
        public CkMachineSample()
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
