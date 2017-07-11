using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsVipLevelDTO : DtoBase<int>
    {
        public BsVipLevelDTO()
        {
        }

        [DataMember]
        public int? VipTypeId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public decimal? Discount { get; set; }

        [DataMember]
        public decimal? DefaultBalance { get; set; }

        [DataMember]
        public int? OrderBy { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }

        [DataMember]
        public int? InValidDays { get; set; }

        [DataMember]
        public bool? IsVipPrice { get; set; }

        [DataMember]
        public bool? IsStoredCard { get; set; }

        [DataMember]
        public string Memo { get; set; }
    }
}
