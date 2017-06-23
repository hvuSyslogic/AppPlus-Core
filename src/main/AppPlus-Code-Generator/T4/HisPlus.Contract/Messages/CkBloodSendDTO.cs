using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkBloodSendDTO : DtoBase<int>
    {
        public CkBloodSendDTO()
        {
        }

        public string RecNo { get; set; }
        public int LabId { get; set; }
        public int BloodId { get; set; }
        public System.DateTime NoteTime { get; set; }
        public int NoteOperId { get; set; }
        public bool? IsSend { get; set; }
        public System.DateTime? SendTime { get; set; }
        public int? SendOperId { get; set; }
        public string TakeMan { get; set; }
        public string Memo { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
