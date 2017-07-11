using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

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
    }
}
