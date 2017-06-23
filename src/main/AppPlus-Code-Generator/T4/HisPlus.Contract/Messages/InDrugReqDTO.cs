using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InDrugReqDTO : DtoBase<int>
    {
        public InDrugReqDTO()
        {
        }

        public string RequestNo { get; set; }
        public int LocationId { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int RoomId { get; set; }
        public short LsSendStatus { get; set; }
        public bool IsPrint { get; set; }
        public int? ConfirmOperId { get; set; }
        public System.DateTime? ConfirmDate { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
    }
}
