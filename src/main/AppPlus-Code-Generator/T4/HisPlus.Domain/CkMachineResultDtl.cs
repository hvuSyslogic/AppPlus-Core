using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CkMachineResultDtl : EntityBase<int>
    {
        public CkMachineResultDtl()
        {    
        }

        public int ResultId { get; set; }
        public int TestId { get; set; }
        public string Result { get; set; }
        public string Bench { get; set; }
    }
}
