using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class DgIllCureDTO : DtoBase<int>
    {
        public DgIllCureDTO()
        {
        }

        [DataMember]
        public int? IllId { get; set; }

        [DataMember]
        public int? IllGroupId { get; set; }

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
        public bool? IsBaby { get; set; }

        [DataMember]
        public bool? IsWomen { get; set; }

        [DataMember]
        public bool? IsMen { get; set; }

        [DataMember]
        public bool? IsOlder { get; set; }

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

        [DataMember]
        public short IconIndex { get; set; }

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
    }
}
