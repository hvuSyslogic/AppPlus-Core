using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

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
    }
}
