using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RdCurePlanDTO : DtoBase<int>
    {
        public RdCurePlanDTO()
        {
        }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public string Illness { get; set; }

        [DataMember]
        public string CureItem { get; set; }

        [DataMember]
        public string CurePlan { get; set; }

        [DataMember]
        public System.DateTime? BeginTime { get; set; }

        [DataMember]
        public System.DateTime? EndTime { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }
    }
}
