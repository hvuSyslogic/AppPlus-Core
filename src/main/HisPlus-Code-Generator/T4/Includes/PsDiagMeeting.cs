using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class PsDiagMeeting : EntityBase<int>
    {
        public PsDiagMeeting()
        {    
        }

        public string ApplyNo { get; set; }
        public System.DateTime ApplyTime { get; set; }
        public int? HospId { get; set; }
        public int? LocationId { get; set; }
        public int? DoctorId { get; set; }
        public string Diagnose { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Clinic { get; set; }
        public bool IsUrgent { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
