using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsBpEvaluateTestDTO : DtoBase<int>
    {
        public BsBpEvaluateTestDTO()
        {
        }

        public int? BpItemId { get; set; }
        public int? EvaluateId { get; set; }
        public bool? IsCommon { get; set; }
        public int? BpIllId { get; set; }
        public int? TestType { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
