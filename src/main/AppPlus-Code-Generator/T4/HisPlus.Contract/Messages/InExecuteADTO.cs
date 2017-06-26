using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InExecuteADTO : DtoBase<System.DateTime>
    {
        public InExecuteADTO()
        {
        }

        [DataMember]
        public System.DateTime? PrintOperTime { get; set; }

        [DataMember]
        public int? PrintOperId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public System.DateTime? AdviceTime { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public short? GroupNum { get; set; }

        [DataMember]
        public int? ItemId { get; set; }

        [DataMember]
        public decimal? Dosage { get; set; }

        [DataMember]
        public int? UnitTakeId { get; set; }

        [DataMember]
        public int? FrequencyId { get; set; }

        [DataMember]
        public int? UsageId { get; set; }

        [DataMember]
        public decimal? PriceIn { get; set; }

        [DataMember]
        public decimal? Totality { get; set; }

        [DataMember]
        public int? UnitInId { get; set; }

        [DataMember]
        public bool? IsUrgent { get; set; }

        [DataMember]
        public bool? IsAttach { get; set; }

        [DataMember]
        public bool? IsSelf { get; set; }

        [DataMember]
        public short? LsSpecialUsage { get; set; }

        [DataMember]
        public short? LsExecLoc { get; set; }

        [DataMember]
        public bool? IsSkin { get; set; }

        [DataMember]
        public System.DateTime? SkinTime { get; set; }

        [DataMember]
        public string SkinTest { get; set; }

        [DataMember]
        public int? DetailId { get; set; }

        [DataMember]
        public int? ExecLocId { get; set; }

        [DataMember]
        public bool? IsExecuted { get; set; }

        [DataMember]
        public System.DateTime? ExecutedTime { get; set; }

        [DataMember]
        public int? ExecutedOperId { get; set; }

        [DataMember]
        public bool? IsMinus { get; set; }

        [DataMember]
        public string NurseMemo { get; set; }

        [DataMember]
        public System.DateTime? MemoTime { get; set; }

        [DataMember]
        public int? MemoOperId { get; set; }

        [DataMember]
        public short? FirstDay { get; set; }

        [DataMember]
        public short? LastDay { get; set; }

        [DataMember]
        public bool? IsLastLong { get; set; }
    }
}
