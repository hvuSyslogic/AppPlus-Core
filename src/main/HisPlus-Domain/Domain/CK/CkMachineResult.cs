using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CkMachineResult : EntityBase<int>
    {
        public CkMachineResult()
        {    
        }

        public int LabId { get; set; }
        public string SampleNum { get; set; }
        public System.DateTime TestDate { get; set; }
        public int MachineId { get; set; }
        public int TestTypeId { get; set; }
    }
}
