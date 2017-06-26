using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OpsApply : EntityBase<int>
    {
        public OpsApply()
        {    
        }

        public string ApplyNo { get; set; }
        public System.DateTime ApplyTime { get; set; }
        public int? MzRegId { get; set; }
        public int? HospId { get; set; }
        public int? LocationId { get; set; }
        public int? DoctorId { get; set; }
        public int? OpsId { get; set; }
        public int? OpsOtherId { get; set; }
        public int? AnaeId { get; set; }
        public string Assistant { get; set; }
        public string Diagnose { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string BedNo { get; set; }
        public short? LsHbsAg { get; set; }
        public short? LsAsepsis { get; set; }
        public string BloodGroup { get; set; }
        public string Blood { get; set; }
        public string OpsBody { get; set; }
        public string OpsPos { get; set; }
        public string OtherTools { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsCalled { get; set; }
        public string Memo { get; set; }
        public int? PlanOperId { get; set; }
        public System.DateTime? PlanTime { get; set; }
        public string PlanMemo { get; set; }
        public bool? IsFinish { get; set; }
        public System.DateTime? FinishTime { get; set; }
        public int? FinishOperId { get; set; }
        public string FinishMemo { get; set; }
        public System.DateTime? BeginTime { get; set; }
        public System.DateTime? EndTime { get; set; }
        public string BloodSum { get; set; }
        public short? LsCutClass { get; set; }
        public short? LsCure { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string BloodRpt { get; set; }
        public string Sensitive { get; set; }
        public int? OpsRoomId { get; set; }
        public string SeqNum { get; set; }
    }
}
