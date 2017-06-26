using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsPriceAddDTO : DtoBase<int>
    {
        public BsPriceAddDTO()
        {
        }

        [DataMember]
        public decimal PriceLow { get; set; }

        [DataMember]
        public decimal? PriceHigh { get; set; }

        [DataMember]
        public decimal? AddPercent { get; set; }

        [DataMember]
        public decimal? AddPrice { get; set; }

        [DataMember]
        public string FeeIds { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
