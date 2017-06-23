using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
