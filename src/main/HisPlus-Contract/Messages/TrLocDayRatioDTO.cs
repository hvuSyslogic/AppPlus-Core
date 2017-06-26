using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class TrLocDayRatioDTO : DtoBase<int>
    {
        public TrLocDayRatioDTO()
        {
        }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public System.DateTime RegDate { get; set; }

        [DataMember]
        public decimal MedicineRatio { get; set; }

        [DataMember]
        public decimal? AntiBiRatio { get; set; }

        [DataMember]
        public decimal? Ratio1 { get; set; }

        [DataMember]
        public decimal? Ratio2 { get; set; }

        [DataMember]
        public decimal? Ratio3 { get; set; }

        [DataMember]
        public decimal? Ratio4 { get; set; }

        [DataMember]
        public decimal? Ratio5 { get; set; }

        [DataMember]
        public decimal? Ratio6 { get; set; }

        [DataMember]
        public decimal? Ratio7 { get; set; }

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
