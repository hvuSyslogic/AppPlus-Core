using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InChangeBed : EntityBase<int>
    {
        public InChangeBed()
        {    
        }

        public int HospId { get; set; }
        public short LsLocal { get; set; }
        public System.DateTime ChgTime { get; set; }
        public int PreBed { get; set; }
        public int PostBed { get; set; }
        public string Reason { get; set; }
        public int DoctorId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
    }
}
