using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsBpEvaluate : EntityBase<int>
    {
        public BsBpEvaluate()
        {    
        }

        public int? EvaluateId { get; set; }
        public string EvaluateName { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
