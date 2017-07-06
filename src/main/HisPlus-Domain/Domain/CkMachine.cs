using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkMachine : EntityBase<int>
    {
        public CkMachine()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int TestTypeId { get; set; }
        public int? TypeNum { get; set; }
        public string MachineNum { get; set; }
        public string FirstSampleNum { get; set; }
        public string LastSampleNum { get; set; }
        public System.DateTime? SampleBeginDate { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short? IconIndex { get; set; }
    }
}
