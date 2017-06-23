using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkBldDonateDTO : DtoBase<int>
    {
        public CkBldDonateDTO()
        {
        }

        public int? HospId { get; set; }
        public int? LocationId { get; set; }
        public string BloodGroup { get; set; }
        public string Rhd { get; set; }
        public int? BloodTypeId { get; set; }
        public decimal? Vollume { get; set; }
        public string Memo { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
