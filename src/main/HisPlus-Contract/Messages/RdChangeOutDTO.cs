using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RdChangeOutDTO : DtoBase<int>
    {
        public RdChangeOutDTO()
        {
        }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public int? MzRegId { get; set; }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public System.DateTime? ChangeTime { get; set; }

        [DataMember]
        public string Reason { get; set; }

        [DataMember]
        public string ToHospital { get; set; }

        [DataMember]
        public System.DateTime? BackTime { get; set; }

        [DataMember]
        public string BackDiagnose { get; set; }

        [DataMember]
        public string Disposal { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public string IllDesc { get; set; }

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
