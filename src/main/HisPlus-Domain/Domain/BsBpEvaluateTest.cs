using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsBpEvaluateTest : EntityBase<int>
    {
        public BsBpEvaluateTest()
        {    
        }

        public int? BpItemId { get; set; }
        public int? EvaluateId { get; set; }
        public bool? IsCommon { get; set; }
        public int? BpIllId { get; set; }
        public int? TestType { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
