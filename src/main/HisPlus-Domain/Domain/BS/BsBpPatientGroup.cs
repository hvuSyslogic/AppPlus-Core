using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsBpPatientGroup : EntityBase<int>
    {
        public BsBpPatientGroup()
        {    
        }

        public string PatientGroup { get; set; }
        public int? BpIllId { get; set; }
        public int? OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
