using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class DgRoadDtlDTO : DtoBase<int>
    {
        public DgRoadDtlDTO()
        {
        }

        [DataMember]
        public int RoadId { get; set; }

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
        public string Name { get; set; }

        [DataMember]
        public string Spec { get; set; }

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
        public bool? IsNeed { get; set; }

        [DataMember]
        public bool? IsReason { get; set; }

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
