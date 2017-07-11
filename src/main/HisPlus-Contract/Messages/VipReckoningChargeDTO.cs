using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class VipReckoningChargeDTO : DtoBase<int>
    {
        public VipReckoningChargeDTO()
        {
        }

        [DataMember]
        public int? VipCardId { get; set; }

        [DataMember]
        public int? ItemId { get; set; }

        [DataMember]
        public int? TotalCount { get; set; }

        [DataMember]
        public int? ConsumeCount { get; set; }

        [DataMember]
        public System.DateTime? LastChargeTime { get; set; }

        [DataMember]
        public decimal? DiscountPrice { get; set; }

        [DataMember]
        public bool? IsDiscount { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }

        [DataMember]
        public string Comments { get; set; }
    }
}
