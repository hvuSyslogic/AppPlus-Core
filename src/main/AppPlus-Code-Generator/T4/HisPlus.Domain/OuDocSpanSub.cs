using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OuDocSpanSub : EntityBase<int>
    {
        public OuDocSpanSub()
        {    
        }

        public int? Weekplanid { get; set; }
        public int? Spanlimitnum { get; set; }
        public int? Sublimitnum { get; set; }
        public int? Timespansubid { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
