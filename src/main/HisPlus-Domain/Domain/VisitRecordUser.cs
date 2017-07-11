using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class VisitRecordUser : EntityBase<int>
    {
        public VisitRecordUser()
        {    
        }

        public int? UserId { get; set; }
        public int? DoctorId { get; set; }
        public int? LsUserRole { get; set; }
    }
}
