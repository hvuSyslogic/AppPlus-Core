using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblEmailDTO : DtoBase<int>
    {
        public GblEmailDTO()
        {
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string FileName { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsSign { get; set; }
        public bool IsPriority { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
