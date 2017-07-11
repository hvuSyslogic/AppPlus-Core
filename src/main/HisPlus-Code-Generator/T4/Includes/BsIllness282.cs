using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsIllness282 : EntityBase<int>
    {
        public BsIllness282()
        {    
        }

        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public string OtherCode { get; set; }
        public string OtherDesc { get; set; }
        public int? BelongIcd { get; set; }
        public decimal? FeeHigh { get; set; }
        public short? DayHigh { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public bool? IsInfectious { get; set; }
    }
}
