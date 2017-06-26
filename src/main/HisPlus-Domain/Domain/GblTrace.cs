using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
