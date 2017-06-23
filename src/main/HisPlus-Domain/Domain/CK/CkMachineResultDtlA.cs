using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CkMachineResultDtlA : EntityBase<System.DateTime>
    {
        public CkMachineResultDtlA()
        {    
        }

        public string Result { get; set; }
        public string Bench { get; set; }
    }
}
