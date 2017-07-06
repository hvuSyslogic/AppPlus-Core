using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class VipChargeItemDTO : DtoBase<int>
    {
        public VipChargeItemDTO()
        {
        }

        [DataMember]
        public int? VccId { get; set; }

        [DataMember]
        public int? ItemId { get; set; }

        [DataMember]
        public int? TotalCount { get; set; }

        [DataMember]
        public decimal? DiscountPrice { get; set; }

        [DataMember]
        public bool? IsDisCount { get; set; }
    }
}
