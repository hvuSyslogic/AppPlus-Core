using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsItemListDTO : DtoBase<int>
    {
        public BsItemListDTO()
        {
        }

        [DataMember]
        public int? IllId { get; set; }

        [DataMember]
        public string IllName { get; set; }

        [DataMember]
        public int? GroupId { get; set; }

        [DataMember]
        public string PatientGroup { get; set; }

        [DataMember]
        public int? UnDrugId { get; set; }

        [DataMember]
        public string UnDrugName { get; set; }

        [DataMember]
        public int? TypeCode { get; set; }

        [DataMember]
        public int? ItemId { get; set; }

        [DataMember]
        public string ItemName { get; set; }

        [DataMember]
        public int? UnitId { get; set; }

        [DataMember]
        public string UnitName { get; set; }

        [DataMember]
        public int? UsageId { get; set; }

        [DataMember]
        public string UsageName { get; set; }

        [DataMember]
        public int? FrequencyId { get; set; }

        [DataMember]
        public string FrequencyName { get; set; }

        [DataMember]
        public decimal? Quantity { get; set; }

        [DataMember]
        public int? RelationCode { get; set; }

        [DataMember]
        public string WayCode { get; set; }

        [DataMember]
        public string Remark { get; set; }

        [DataMember]
        public System.DateTime? ImpTime { get; set; }
    }
}
