using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class VipChargeConfigDTO : DtoBase<int>
    {
        public VipChargeConfigDTO()
        {
        }

        [DataMember]
        public int? Viplevelid { get; set; }

        [DataMember]
        public decimal? Balance { get; set; }

        [DataMember]
        public decimal? Givingintegral1 { get; set; }

        [DataMember]
        public decimal? Givingintegral2 { get; set; }
    }
}
