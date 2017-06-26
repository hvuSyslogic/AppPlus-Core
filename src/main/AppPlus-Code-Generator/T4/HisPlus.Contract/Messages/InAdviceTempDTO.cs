using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InAdviceTempDTO : DtoBase<int>
    {
        public InAdviceTempDTO()
        {
        }

        [DataMember]
        public System.DateTime? AdviceTime { get; set; }

        [DataMember]
        public int DoctorId { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public short GroupNum { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public decimal Dosage { get; set; }

        [DataMember]
        public int? UnitTakeId { get; set; }

        [DataMember]
        public int? FrequencyId { get; set; }

        [DataMember]
        public int? UsageId { get; set; }

        [DataMember]
        public decimal PriceIn { get; set; }

        [DataMember]
        public decimal Totality { get; set; }

        [DataMember]
        public int UnitInId { get; set; }

        [DataMember]
        public bool IsUrgent { get; set; }

        [DataMember]
        public bool IsAttach { get; set; }

        [DataMember]
        public bool IsSelf { get; set; }

        [DataMember]
        public short LsSpecialUsage { get; set; }

        [DataMember]
        public short LsExecLoc { get; set; }

        [DataMember]
        public bool IsSkin { get; set; }

        [DataMember]
        public System.DateTime? SkinTime { get; set; }

        [DataMember]
        public string SkinTest { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public bool IsPrinted { get; set; }

        [DataMember]
        public bool? IsOtherFee { get; set; }

        [DataMember]
        public bool IsChk { get; set; }

        [DataMember]
        public System.DateTime? ChkOperTime { get; set; }

        [DataMember]
        public int? ChkOperId { get; set; }

        [DataMember]
        public bool IsAuth { get; set; }

        [DataMember]
        public System.DateTime? AuthOperTime { get; set; }

        [DataMember]
        public int? AuthOperId { get; set; }

        [DataMember]
        public bool IsAuthFee { get; set; }

        [DataMember]
        public System.DateTime? AuthFeeOperTime { get; set; }

        [DataMember]
        public int? AuthFeeOperId { get; set; }

        [DataMember]
        public bool IsCancel { get; set; }

        [DataMember]
        public System.DateTime? CancelOperTime { get; set; }

        [DataMember]
        public int? CancelOperId { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public short? Sn { get; set; }

        [DataMember]
        public string F5 { get; set; }

        [DataMember]
        public string F6 { get; set; }

        [DataMember]
        public string F7 { get; set; }

        [DataMember]
        public int ExecLocId { get; set; }

        [DataMember]
        public string F8 { get; set; }

        [DataMember]
        public int? ExecDoctorId { get; set; }

        [DataMember]
        public string BpReason { get; set; }

        [DataMember]
        public bool? IsBp { get; set; }

        [DataMember]
        public int? CureDtlId { get; set; }
    }
}
