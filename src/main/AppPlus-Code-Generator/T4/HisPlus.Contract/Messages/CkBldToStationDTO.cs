using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkBldToStationDTO : DtoBase<int>
    {
        public CkBldToStationDTO()
        {
        }

        public string RecNo { get; set; }
        public int BloodId { get; set; }
        public System.DateTime? BackTime { get; set; }
        public int? BackOperId { get; set; }
        public string BackReason { get; set; }
        public string Memo { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
