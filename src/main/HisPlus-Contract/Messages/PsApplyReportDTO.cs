using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class PsApplyReportDTO : DtoBase<int>
    {
        public PsApplyReportDTO()
        {
        }

        [DataMember]
        public string ApplyNo { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public int? MzRegId { get; set; }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public bool IsCancel { get; set; }

        [DataMember]
        public System.DateTime? CancelTime { get; set; }

        [DataMember]
        public int? CancelOperId { get; set; }

        [DataMember]
        public short XType { get; set; }

        [DataMember]
        public bool IsPre { get; set; }

        [DataMember]
        public int? ItemId { get; set; }

        [DataMember]
        public bool IsCharged { get; set; }

        [DataMember]
        public bool IsConfirm { get; set; }

        [DataMember]
        public System.DateTime? ConfirmTime { get; set; }

        [DataMember]
        public string Equipment { get; set; }

        [DataMember]
        public string ApplyMemo { get; set; }

        [DataMember]
        public int? ExecLocId { get; set; }

        [DataMember]
        public System.DateTime? CheckTime { get; set; }

        [DataMember]
        public int? CheckOperId { get; set; }

        [DataMember]
        public System.DateTime? ReportTime { get; set; }

        [DataMember]
        public int? ReportOperId { get; set; }

        [DataMember]
        public int? AuthOperId { get; set; }

        [DataMember]
        public string CheckBody { get; set; }

        [DataMember]
        public string CheckParm { get; set; }

        [DataMember]
        public string CheckDesc { get; set; }

        [DataMember]
        public string CheckResult { get; set; }

        [DataMember]
        public string CheckAdvice { get; set; }

        [DataMember]
        public bool IsAbNormal { get; set; }

        [DataMember]
        public string Summary { get; set; }

        [DataMember]
        public string Diagnose { get; set; }

        [DataMember]
        public int? CheckId { get; set; }

        [DataMember]
        public int? ExecuteId { get; set; }

        [DataMember]
        public string CallGroup { get; set; }

        [DataMember]
        public short? LsStatus { get; set; }
    }
}
