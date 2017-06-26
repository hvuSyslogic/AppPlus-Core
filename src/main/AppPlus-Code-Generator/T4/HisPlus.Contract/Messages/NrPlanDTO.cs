using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class NrPlanDTO : DtoBase<int>
    {
        public NrPlanDTO()
        {
        }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? IcdId { get; set; }

        [DataMember]
        public string IllDesc { get; set; }

        [DataMember]
        public string Target { get; set; }

        [DataMember]
        public string Measure { get; set; }

        [DataMember]
        public string BasisOf { get; set; }

        [DataMember]
        public string Evaluate { get; set; }

        [DataMember]
        public int? EvalOperId { get; set; }

        [DataMember]
        public System.DateTime? EvalTime { get; set; }

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
