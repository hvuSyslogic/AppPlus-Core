using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsItemLocationDTO : DtoBase<int>
    {
        public BsItemLocationDTO()
        {
        }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public int? FeeHsMzId { get; set; }

        [DataMember]
        public int? FeeHsZyId { get; set; }

        [DataMember]
        public decimal? Dosage { get; set; }

        [DataMember]
        public int? UnitTake { get; set; }

        [DataMember]
        public int? FrequencyId { get; set; }

        [DataMember]
        public int? UsageId { get; set; }

        [DataMember]
        public bool IsLocDrug { get; set; }

        [DataMember]
        public int OrderBy { get; set; }

        [DataMember]
        public short IconIndex { get; set; }

        [DataMember]
        public int? ExecLocId { get; set; }

        [DataMember]
        public bool? IsLocUse { get; set; }
    }
}
