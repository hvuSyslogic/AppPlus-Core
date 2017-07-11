using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

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
    }
}
