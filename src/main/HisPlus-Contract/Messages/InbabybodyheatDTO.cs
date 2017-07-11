using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InbabybodyheatDTO : DtoBase<int>
    {
        public InbabybodyheatDTO()
        {
        }

        [DataMember]
        public int Hospid { get; set; }

        [DataMember]
        public System.DateTime Opertime { get; set; }

        [DataMember]
        public int Operid { get; set; }

        [DataMember]
        public decimal Animalheat { get; set; }

        [DataMember]
        public string Heattype { get; set; }

        [DataMember]
        public short Pulse { get; set; }

        [DataMember]
        public short Heart { get; set; }

        [DataMember]
        public string Breath { get; set; }

        [DataMember]
        public string Stool { get; set; }

        [DataMember]
        public string Urine { get; set; }

        [DataMember]
        public string Weight { get; set; }

        [DataMember]
        public string Bldpress0 { get; set; }

        [DataMember]
        public string Bldpress1 { get; set; }

        [DataMember]
        public string Fluidm { get; set; }

        [DataMember]
        public string Totalin { get; set; }

        [DataMember]
        public string Urinem { get; set; }

        [DataMember]
        public string Otherm { get; set; }

        [DataMember]
        public string Totalout { get; set; }

        [DataMember]
        public string Memoup { get; set; }

        [DataMember]
        public string Memodn { get; set; }

        [DataMember]
        public bool Spintest { get; set; }

        [DataMember]
        public bool Lowertemp { get; set; }

        [DataMember]
        public bool Isrecheck { get; set; }

        [DataMember]
        public bool Isoutside { get; set; }

        [DataMember]
        public bool Ismachine { get; set; }

        [DataMember]
        public string Others { get; set; }

        [DataMember]
        public bool Isops { get; set; }

        [DataMember]
        public System.DateTime? Birthtime { get; set; }

        [DataMember]
        public bool Isreject { get; set; }

        [DataMember]
        public System.DateTime? Deadtime { get; set; }

        [DataMember]
        public int? Locationid { get; set; }

        [DataMember]
        public decimal? Bg { get; set; }

        [DataMember]
        public string Cwinject { get; set; }

        [DataMember]
        public string Jminject { get; set; }

        [DataMember]
        public string Cwheight { get; set; }

        [DataMember]
        public bool? Ismotherfeed { get; set; }

        [DataMember]
        public bool? Ishumanfeed { get; set; }

        [DataMember]
        public int? Ubsstool { get; set; }

        [DataMember]
        public int? Umbilical { get; set; }

        [DataMember]
        public string TimeQuantum { get; set; }

        [DataMember]
        public string UmbilicalExplain { get; set; }

        [DataMember]
        public string FecesExplain { get; set; }
    }
}
