using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class HustoresDay : EntityBase<int>
    {
        public HustoresDay()
        {    
        }

        public int? CompId { get; set; }
    }
}
