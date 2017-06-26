using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InDaySumDTO : DtoBase<int>
    {
        public InDaySumDTO()
        {
        }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public System.DateTime RegDate { get; set; }

        [DataMember]
        public decimal NotPay { get; set; }

        [DataMember]
        public decimal HasPay { get; set; }

        [DataMember]
        public decimal DaySum { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public decimal? Remain { get; set; }
    }
}
