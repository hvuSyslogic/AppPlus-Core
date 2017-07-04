using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuExecuteDtlDTO : DtoBase<int>
    {
        public OuExecuteDtlDTO()
        {
        }

        [DataMember]
        public int ExecuteId { get; set; }

        [DataMember]
        public int? RecipeDtlId { get; set; }

        [DataMember]
        public int ListNum { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public decimal Dosage { get; set; }

        [DataMember]
        public int UnitId { get; set; }

        [DataMember]
        public int UsageId { get; set; }

        [DataMember]
        public int FrequencyId { get; set; }

        [DataMember]
        public short Days { get; set; }

        [DataMember]
        public decimal? Totality { get; set; }

        [DataMember]
        public int? UnitDiagId { get; set; }

        [DataMember]
        public System.DateTime? IssueTime { get; set; }

        [DataMember]
        public System.DateTime? BackTime { get; set; }

        [DataMember]
        public bool? IsExecuted { get; set; }

        [DataMember]
        public System.DateTime? ExecutedTime { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }
    }
}
