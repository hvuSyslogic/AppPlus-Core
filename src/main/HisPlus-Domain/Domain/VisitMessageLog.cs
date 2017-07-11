using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class VisitMessageLog : EntityBase<int>
    {
        public VisitMessageLog()
        {    
        }

        public int PatId { get; set; }
        public string PatientName { get; set; }
        public string Mobile { get; set; }
        public string Comments { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? OperTime { get; set; }
    }
}
