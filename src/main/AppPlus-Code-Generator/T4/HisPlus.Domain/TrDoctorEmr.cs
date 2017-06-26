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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
