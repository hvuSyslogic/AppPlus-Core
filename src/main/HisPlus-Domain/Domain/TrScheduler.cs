using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class TrScheduler : EntityBase<int>
    {
        public TrScheduler()
        {    
        }

        public int UserId { get; set; }
        public int LineId { get; set; }
        public System.DateTime ScheTime { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public short? IconIndex { get; set; }
    }
}
