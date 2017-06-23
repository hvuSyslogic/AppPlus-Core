using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InAdviceWeekDayDTO : DtoBase<int>
    {
        public InAdviceWeekDayDTO()
        {
        }

        public int AdviceId { get; set; }
        public short WeekDay { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
