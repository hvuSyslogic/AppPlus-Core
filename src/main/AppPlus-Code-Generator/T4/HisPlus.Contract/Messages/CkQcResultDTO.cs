using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkQcResultDTO : DtoBase<int>
    {
        public CkQcResultDTO()
        {
        }

        public System.DateTime ResultDate { get; set; }
        public string Result { get; set; }
        public string ResultComment { get; set; }
        public int OperId { get; set; }
        public string ResultStatus { get; set; }
        public int LotId { get; set; }
        public int TestId { get; set; }
        public int CtrlId { get; set; }
        public bool? IsShowQc { get; set; }
        public string RejectMemo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
