using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class GblGetSequenceNum : EntityBase<int>
    {
        public GblGetSequenceNum()
        {    
        }

        public long NextSequenceNum { get; set; }
        public bool IsDayBegin { get; set; }
        public string GetdateStr { get; private set; }
        public string NextSequenceStr { get; private set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
