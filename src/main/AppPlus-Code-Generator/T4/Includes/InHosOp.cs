using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class InHosOp : EntityBase<int>
    {
        public InHosOp()
        {    
        }

        public int HospId { get; set; }
        public int OpsTimes { get; set; }
        public System.DateTime? OpsTime { get; set; }
        public int? OpsId { get; set; }
        public short? LsCut { get; set; }
        public short? LsRecove { get; set; }
        public int? OpsDoctorId { get; set; }
        public int? AnaesId { get; set; }
        public int? AssistantOperId1 { get; set; }
        public int? AssistantOperId2 { get; set; }
        public int? AnaesDoctorId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
