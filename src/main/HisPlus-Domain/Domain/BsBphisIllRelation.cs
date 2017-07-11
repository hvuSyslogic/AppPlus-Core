using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsBphisIllRelation : EntityBase<int>
    {
        public BsBphisIllRelation()
        {    
        }

        public int? BpIllId { get; set; }
        public int? HisIllId { get; set; }
    }
}
