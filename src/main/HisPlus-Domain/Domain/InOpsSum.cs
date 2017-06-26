using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InOpsSum : EntityBase<int>
    {
        public InOpsSum()
        {    
        }

        public int LocationId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public int SelectDateNum { get; set; }
        public int EmergencyNum { get; set; }
        public int OutPatientNum { get; set; }
        public string Memo { get; set; }
    }
}
