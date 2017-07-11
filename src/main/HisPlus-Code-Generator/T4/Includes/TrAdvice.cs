using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
