using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblTrace : EntityBase<int>
    {
        public GblTrace()
        {    
        }

        public string SqlString { get; set; }
        public string WhereCondition { get; set; }
        public string OrderByExpression { get; set; }
        public bool IsActive { get; set; }
    }
}
