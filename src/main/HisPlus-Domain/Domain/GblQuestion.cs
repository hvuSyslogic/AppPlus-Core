using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblQuestion : EntityBase<int>
    {
        public GblQuestion()
        {    
        }

        public string Question { get; set; }
        public string Answer { get; set; }
        public int SystemId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
    }
}
