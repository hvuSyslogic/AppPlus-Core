using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OpsApplyDTO : DtoBase<int>
    {
        public OpsApplyDTO()
        {
        }

        [DataMember]
        public string ApplyNo { get; set; }

        [DataMember]
        public System.DateTime ApplyTime { get; set; }

        [DataMember]
        public int? MzRegId { get; set; }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public int? OpsId { get; set; }

        [DataMember]
        public int? OpsOtherId { get; set; }

        [DataMember]
        public int? AnaeId { get; set; }

        [DataMember]
        public string Assistant { get; set; }

        [DataMember]
        public string Diagnose { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public string BedNo { get; set; }

        [DataMember]
        public short? LsHbsAg { get; set; }

        [DataMember]
        public short? LsAsepsis { get; set; }

        [DataMember]
        public string BloodGroup { get; set; }

        [DataMember]
        public string Blood { get; set; }

        [DataMember]
        public string OpsBody { get; set; }

        [DataMember]
        public string OpsPos { get; set; }

        [DataMember]
        public string OtherTools { get; set; }

        [DataMember]
        public bool IsUrgent { get; set; }

        [DataMember]
        public bool IsCalled { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public int? PlanOperId { get; set; }

        [DataMember]
        public System.DateTime? PlanTime { get; set; }

        [DataMember]
        public string PlanMemo { get; set; }

        [DataMember]
        public bool? IsFinish { get; set; }

        [DataMember]
        public System.DateTime? FinishTime { get; set; }

        [DataMember]
        public int? FinishOperId { get; set; }

        [DataMember]
        public string FinishMemo { get; set; }

        [DataMember]
        public System.DateTime? BeginTime { get; set; }

        [DataMember]
        public System.DateTime? EndTime { get; set; }

        [DataMember]
        public string BloodSum { get; set; }

        [DataMember]
        public short? LsCutClass { get; set; }

        [DataMember]
        public short? LsCure { get; set; }

        [DataMember]
        public string BloodRpt { get; set; }

        [DataMember]
        public string Sensitive { get; set; }

        [DataMember]
        public int? OpsRoomId { get; set; }

        [DataMember]
        public string SeqNum { get; set; }
    }
}
