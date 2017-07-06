using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class VipCardDTO : DtoBase<int>
    {
        public VipCardDTO()
        {
        }

        [DataMember]
        public int? PatId { get; set; }

        [DataMember]
        public string CardNo { get; set; }

        [DataMember]
        public int? VipLevelId { get; set; }

        [DataMember]
        public decimal? Discount { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public System.DateTime? CreateTime { get; set; }

        [DataMember]
        public System.DateTime? InvalidDate { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public int? CardStatus { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }

        [DataMember]
        public string IntroducerId { get; set; }

        [DataMember]
        public int? IntroducerOperId { get; set; }

        [DataMember]
        public System.DateTime? ModiTime { get; set; }

        [DataMember]
        public int? ModiOperId { get; set; }

        [DataMember]
        public System.DateTime? SalesDate { get; set; }
    }
}
