using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkCompGroupPsApplyDTO : DtoBase<int>
    {
        public CkCompGroupPsApplyDTO()
        {
        }

        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public short XType { get; set; }
        public bool IsPre { get; set; }
        public int? ItemId { get; set; }
        public string ApplyMemo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Summary { get; set; }
        public string Diagnose { get; set; }
        public int? CompGroupId { get; set; }
    }
}
