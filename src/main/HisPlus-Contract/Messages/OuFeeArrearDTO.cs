using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuFeeArrearDTO : DtoBase<int>
    {
        public OuFeeArrearDTO()
        {
        }

        [DataMember]
        public int? PatId { get; set; }

        [DataMember]
        public int? MzRegId { get; set; }

        [DataMember]
        public int? ItemId { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public bool? IsPay { get; set; }

        [DataMember]
        public System.DateTime? PayTime { get; set; }
    }
}
