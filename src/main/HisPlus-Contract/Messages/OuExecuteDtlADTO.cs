using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuExecuteDtlADTO : DtoBase<System.DateTime>
    {
        public OuExecuteDtlADTO()
        {
        }

        [DataMember]
        public int? RecipeDtlId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public decimal? Totality { get; set; }

        [DataMember]
        public int? UnitDiagId { get; set; }

        [DataMember]
        public System.DateTime? IssueTime { get; set; }

        [DataMember]
        public System.DateTime? BackTime { get; set; }
    }
}
