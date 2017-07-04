using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OaSchedule : EntityBase<int>
    {
        public OaSchedule()
        {    
        }

        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public System.DateTime? StartTime { get; set; }
        public System.DateTime? EndTime { get; set; }
        public string Description { get; set; }
        public int? LabelId { get; set; }
        public System.DateTime? Reminder { get; set; }
    }
}
