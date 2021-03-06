using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class TrAdvice : EntityBase<int>
    {
        public TrAdvice()
        {    
        }

        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public int AdviceId { get; set; }
        public short LsMarkType { get; set; }
        public string Type { get; set; }
        public string Before { get; set; }
        public string After { get; set; }
        public int? HospId { get; set; }
    }
}
