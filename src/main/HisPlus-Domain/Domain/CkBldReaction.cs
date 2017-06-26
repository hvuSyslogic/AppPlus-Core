using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkBldReaction : EntityBase<int>
    {
        public CkBldReaction()
        {    
        }

        public string RecNo { get; set; }
        public int LabId { get; set; }
        public int? HospId { get; set; }
        public int BloodId { get; set; }
        public System.DateTime? TransTime { get; set; }
        public int? LocationId { get; set; }
        public int? DoctorId { get; set; }
        public string TransType { get; set; }
        public decimal? TotalVollume { get; set; }
        public System.DateTime? ReactTime { get; set; }
        public short? LsTransType { get; set; }
        public string ClincHandle { get; set; }
        public string TransHandle { get; set; }
        public string Memo { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
