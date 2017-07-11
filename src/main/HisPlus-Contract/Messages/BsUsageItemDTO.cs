using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsUsageItemDTO : DtoBase<int>
    {
        public BsUsageItemDTO()
        {
        }

        [DataMember]
        public int UsageId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public decimal Totality { get; set; }

        [DataMember]
        public short LsUseArea { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public short IconIndex { get; set; }

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
        public bool? IsDrugTwoDay { get; set; }
    }
}
