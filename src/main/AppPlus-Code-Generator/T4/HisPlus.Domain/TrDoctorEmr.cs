using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class TrDoctorEmr : EntityBase<int>
    {
        public TrDoctorEmr()
        {    
        }

        public int DoctorId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int PatId { get; set; }
    }
}
