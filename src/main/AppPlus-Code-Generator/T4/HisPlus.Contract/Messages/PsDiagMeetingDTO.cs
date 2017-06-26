using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class PsDiagMeetingDTO : DtoBase<int>
    {
        public PsDiagMeetingDTO()
        {
        }

        [DataMember]
        public string ApplyNo { get; set; }

        [DataMember]
        public System.DateTime ApplyTime { get; set; }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public string Diagnose { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public string Clinic { get; set; }

        [DataMember]
        public bool IsUrgent { get; set; }

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
    }
}
