using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class VipCardDiscountDTO : DtoBase<int>
    {
        public VipCardDiscountDTO()
        {
        }

        [DataMember]
        public int? VipCardId { get; set; }

        [DataMember]
        public int? FeeId { get; set; }

        [DataMember]
        public decimal? Discount { get; set; }
    }
}
