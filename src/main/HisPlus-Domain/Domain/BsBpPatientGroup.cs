using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

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
    }
}
