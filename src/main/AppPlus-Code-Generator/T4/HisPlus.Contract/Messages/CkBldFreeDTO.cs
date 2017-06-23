using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkBldFreeDTO : DtoBase<int>
    {
        public CkBldFreeDTO()
        {
        }

        public int? HospId { get; set; }
        public int? LocationId { get; set; }
        public string TransType { get; set; }
        public string Memo { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}