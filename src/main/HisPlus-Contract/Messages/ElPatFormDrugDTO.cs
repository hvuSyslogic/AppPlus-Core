using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class ElPatFormDrugDTO : DtoBase<int>
    {
        public ElPatFormDrugDTO()
        {
        }

        [DataMember]
        public int? PatFormId { get; set; }

        [DataMember]
        public int? ListNum { get; set; }

        [DataMember]
        public int? ItemId { get; set; }

        [DataMember]
        public short? GroupNum { get; set; }

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
        public decimal? Totality { get; set; }

        [DataMember]
        public int? UnitDiagId { get; set; }

        [DataMember]
        public bool? IsAttach { get; set; }

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
