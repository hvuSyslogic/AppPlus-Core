using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class RmstoresDay : EntityBase<int>
    {
        public RmstoresDay()
        {    
        }

        public int? CompId { get; set; }
    }
}
