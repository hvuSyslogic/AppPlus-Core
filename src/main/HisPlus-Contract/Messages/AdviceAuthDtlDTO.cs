using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class AdviceAuthDtlDTO : DtoBase<int>
    {
        public AdviceAuthDtlDTO()
        {
        }

        [DataMember]
        public int? LsMarkType { get; set; }

        [DataMember]
        public System.DateTime? AdviceTime { get; set; }

        [DataMember]
        public int? AdviceId { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public int? GroupNum { get; set; }

        [DataMember]
        public int? ItemId { get; set; }

        [DataMember]
        public int? FormId { get; set; }

        [DataMember]
        public decimal? PriceIn { get; set; }

        [DataMember]
        public int? UnitTakeId { get; set; }

        [DataMember]
        public int? FrequencyId { get; set; }

        [DataMember]
        public int? UsageId { get; set; }

        [DataMember]
        public decimal? Totality { get; set; }

        [DataMember]
        public decimal? ToTalityAll { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public int? UnitInId { get; set; }

        [DataMember]
        public bool? IsAttach { get; set; }

        [DataMember]
        public bool? IsSelf { get; set; }

        [DataMember]
        public int? LsSpecialUsage { get; set; }

        [DataMember]
        public int? LsExecLoc { get; set; }

        [DataMember]
        public System.DateTime? SkinTime { get; set; }

        [DataMember]
        public bool? IsSkin { get; set; }

        [DataMember]
        public string SkinTest { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public bool? IsPrinted { get; set; }

        [DataMember]
        public bool? IsChk { get; set; }

        [DataMember]
        public System.DateTime? ChkOperTime { get; set; }

        [DataMember]
        public int? ChkOperId { get; set; }

        [DataMember]
        public bool? IsEnd { get; set; }

        [DataMember]
        public System.DateTime? EndOperTime { get; set; }

        [DataMember]
        public int? EndOperId { get; set; }

        [DataMember]
        public int? EndDoctorId { get; set; }

        [DataMember]
        public bool? IsAuth { get; set; }

        [DataMember]
        public System.DateTime? AuthOperTime { get; set; }

        [DataMember]
        public int? AuthOperId { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public bool? IsOtherFee { get; set; }

        [DataMember]
        public bool? IsBeforeops { get; set; }

        [DataMember]
        public int? LsRpType { get; set; }

        [DataMember]
        public bool? IsInject { get; set; }

        [DataMember]
        public string Sn { get; set; }

        [DataMember]
        public int? FirstDay { get; set; }

        [DataMember]
        public int? LastDay { get; set; }

        [DataMember]
        public int? ExecLocId { get; set; }

        [DataMember]
        public int? OriAdviceId { get; set; }

        [DataMember]
        public int? InfeeCheck { get; set; }

        [DataMember]
        public int? Adcolor { get; set; }

        [DataMember]
        public bool IsManual { get; set; }

        [DataMember]
        public bool? IsArrearage { get; set; }

        [DataMember]
        public bool? IsTodayIn { get; set; }

        [DataMember]
        public int? DrugReqId1 { get; set; }

        [DataMember]
        public int? DrugReqId2 { get; set; }

        [DataMember]
        public int? DetailId1 { get; set; }

        [DataMember]
        public int? DetailId2 { get; set; }

        [DataMember]
        public string AdviceName { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Spec { get; set; }

        [DataMember]
        public int? ExecuteId { get; set; }

        [DataMember]
        public int? ExecuteId2 { get; set; }

        [DataMember]
        public decimal? Dosage { get; set; }

        [DataMember]
        public int? ExecDoctorId { get; set; }

        [DataMember]
        public bool? IsYbxj { get; set; }

        [DataMember]
        public bool? IsAutoMatic { get; set; }

        [DataMember]
        public string YbType { get; set; }

        [DataMember]
        public bool? IsPriority { get; set; }
    }
}
