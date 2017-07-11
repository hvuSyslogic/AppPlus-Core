using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short? IconIndex { get; set; }
    }
}
