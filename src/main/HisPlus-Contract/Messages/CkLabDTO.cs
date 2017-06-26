using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkLabDTO : DtoBase<int>
    {
        public CkLabDTO()
        {
        }

        [DataMember]
        public string LabNum { get; set; }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public int? MzRegId { get; set; }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public short LsSource { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public string RefLocation { get; set; }

        [DataMember]
        public string IllHistory { get; set; }

        [DataMember]
        public string Diagnose { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public bool IsPriority { get; set; }

        [DataMember]
        public System.DateTime? CollectTime { get; set; }

        [DataMember]
        public int? CollectOperId { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public bool IsCancel { get; set; }

        [DataMember]
        public System.DateTime? CancelTime { get; set; }

        [DataMember]
        public int? CancelOperId { get; set; }

        [DataMember]
        public bool? IsPass { get; set; }

        [DataMember]
        public string ReportMemo { get; set; }

        [DataMember]
        public string TechMemo { get; set; }

        [DataMember]
        public string OtherMemo { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public System.DateTime? RecieveTime { get; set; }

        [DataMember]
        public int? RecieveOperId { get; set; }

        [DataMember]
        public System.DateTime? ResultTime { get; set; }

        [DataMember]
        public int? ResultOperId { get; set; }

        [DataMember]
        public System.DateTime? AuthTime { get; set; }

        [DataMember]
        public int? AuthOperId { get; set; }

        [DataMember]
        public System.DateTime? ReportTime { get; set; }

        [DataMember]
        public int? ReportOperId { get; set; }

        [DataMember]
        public short LsStatus { get; set; }

        [DataMember]
        public int? TestTypeId { get; set; }

        [DataMember]
        public int? CollectLocId { get; set; }

        [DataMember]
        public int? TogetherNum { get; set; }

        [DataMember]
        public int? SjOperId { get; set; }

        [DataMember]
        public System.DateTime? SjOperTime { get; set; }
    }
}
