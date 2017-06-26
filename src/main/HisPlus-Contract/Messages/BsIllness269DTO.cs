using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsIllness269DTO : DtoBase<int>
    {
        public BsIllness269DTO()
        {
        }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string OtherCode { get; set; }

        [DataMember]
        public string OtherDesc { get; set; }

        [DataMember]
        public int? BelongIcd { get; set; }

        [DataMember]
        public decimal? FeeHigh { get; set; }

        [DataMember]
        public short? DayHigh { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public bool? IsInfectious { get; set; }
    }
}
