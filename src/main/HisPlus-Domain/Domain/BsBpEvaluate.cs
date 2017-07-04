using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

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
        public string ShortName { get; set; }
    }
}
