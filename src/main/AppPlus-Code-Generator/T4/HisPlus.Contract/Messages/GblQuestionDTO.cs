using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblQuestionDTO : DtoBase<int>
    {
        public GblQuestionDTO()
        {
        }

        public string Question { get; set; }
        public string Answer { get; set; }
        public int SystemId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
