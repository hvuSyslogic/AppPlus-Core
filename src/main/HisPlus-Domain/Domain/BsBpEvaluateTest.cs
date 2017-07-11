using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

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
    }
}
