using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InFeeCheckDTO : DtoBase<int>
    {
        public InFeeCheckDTO()
        {
        }

        public int? DetailId { get; set; }
        public int? AdviceId { get; set; }
        public short? LsMarkType { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
