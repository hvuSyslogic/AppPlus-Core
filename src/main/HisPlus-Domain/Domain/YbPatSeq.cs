using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class YbPatSeq : EntityBase<int>
    {
        public YbPatSeq()
        {    
        }

        public int? MzRegId { get; set; }
        public int? HospId { get; set; }
        public string YbSeq { get; set; }
        public System.DateTime? OperTime { get; set; }
    }
}
