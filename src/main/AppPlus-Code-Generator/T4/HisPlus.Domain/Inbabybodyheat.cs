using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class Inbabybodyheat : EntityBase<int>
    {
        public Inbabybodyheat()
        {    
        }

        public int Hospid { get; set; }
        public System.DateTime Opertime { get; set; }
        public int Operid { get; set; }
        public decimal Animalheat { get; set; }
        public string Heattype { get; set; }
        public short Pulse { get; set; }
        public short Heart { get; set; }
        public string Breath { get; set; }
        public string Stool { get; set; }
        public string Urine { get; set; }
        public string Weight { get; set; }
        public string Bldpress0 { get; set; }
        public string Bldpress1 { get; set; }
        public string Fluidm { get; set; }
        public string Totalin { get; set; }
        public string Urinem { get; set; }
        public string Otherm { get; set; }
        public string Totalout { get; set; }
        public string Memoup { get; set; }
        public string Memodn { get; set; }
        public bool Spintest { get; set; }
        public bool Lowertemp { get; set; }
        public bool Isrecheck { get; set; }
        public bool Isoutside { get; set; }
        public bool Ismachine { get; set; }
        public string Others { get; set; }
        public bool Isops { get; set; }
        public System.DateTime? Birthtime { get; set; }
        public bool Isreject { get; set; }
        public System.DateTime? Deadtime { get; set; }
        public int? Locationid { get; set; }
        public decimal? Bg { get; set; }
        public string Cwinject { get; set; }
        public string Jminject { get; set; }
        public string Cwheight { get; set; }
        public bool? Ismotherfeed { get; set; }
        public bool? Ishumanfeed { get; set; }
        public int? Ubsstool { get; set; }
        public int? Umbilical { get; set; }
        public string TimeQuantum { get; set; }
        public string UmbilicalExplain { get; set; }
        public string FecesExplain { get; set; }
    }
}
