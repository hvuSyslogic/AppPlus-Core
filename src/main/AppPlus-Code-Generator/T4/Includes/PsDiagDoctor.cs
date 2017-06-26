using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class PsDiagDoctor : EntityBase<int>
    {
        public PsDiagDoctor()
        {    
        }

        public int? ApplyId { get; set; }
        public int? LocationId { get; set; }
        public int? DoctorId { get; set; }
        public bool? IsConfirm { get; set; }
        public System.DateTime? ConfirmTime { get; set; }
        public string Answer { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
