using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class DgRoadPatDtlDTO : DtoBase<int>
    {
        public DgRoadPatDtlDTO()
        {
        }

        [DataMember]
        public int? RoadPatId { get; set; }

        [DataMember]
        public int RoadDtlId { get; set; }

        [DataMember]
        public int? DayGroupId { get; set; }

        [DataMember]
        public int? CureId { get; set; }

        [DataMember]
        public int? DrugId { get; set; }

        [DataMember]
        public int? CheckId { get; set; }

        [DataMember]
        public int? NurseId { get; set; }

        [DataMember]
        public short? LsAdvType { get; set; }

        [DataMember]
        public short? LsCureType { get; set; }

        [DataMember]
        public int? CatalogId { get; set; }

        [DataMember]
        public decimal? Dosage { get; set; }

        [DataMember]
        public int? UnitTakeId { get; set; }

        [DataMember]
        public int? FrequencyId { get; set; }

        [DataMember]
        public int? UsageId { get; set; }

        [DataMember]
        public short? Days { get; set; }

        [DataMember]
        public decimal? FeeTotality { get; set; }

        [DataMember]
        public int? UnitId { get; set; }

        [DataMember]
        public bool? IsDelete { get; set; }

        [DataMember]
        public bool? IsChange { get; set; }

        [DataMember]
        public string Reason { get; set; }

        [DataMember]
        public int AdviceId { get; set; }

        [DataMember]
        public short LsMarkType { get; set; }

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
