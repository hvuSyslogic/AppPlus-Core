using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class OaScheduleDTO : DtoBase<int>
    {
        public OaScheduleDTO()
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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
