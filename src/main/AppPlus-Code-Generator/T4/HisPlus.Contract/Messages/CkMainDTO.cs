using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkMainDTO : DtoBase<int>
    {
        public CkMainDTO()
        {
        }

        [DataMember]
        public string CheckNo { get; set; }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public System.DateTime CheckTime { get; set; }

        [DataMember]
        public int? CompanyCkeckId { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public bool IsCancel { get; set; }

        [DataMember]
        public System.DateTime? CancelOperTime { get; set; }

        [DataMember]
        public int? CancelOperId { get; set; }

        [DataMember]
        public string CancelMemo { get; set; }

        [DataMember]
        public System.DateTime? RecieveTime { get; set; }

        [DataMember]
        public int? RecieveOperId { get; set; }

        [DataMember]
        public System.DateTime? ReportTime { get; set; }

        [DataMember]
        public int? ReportOperId { get; set; }

        [DataMember]
        public short? LsStatus { get; set; }

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
        public int? CompanyId { get; set; }

        [DataMember]
        public int? CompanyGroupId { get; set; }

        [DataMember]
        public string RptFileName { get; set; }

        [DataMember]
        public bool? IsPay { get; set; }
    }
}
