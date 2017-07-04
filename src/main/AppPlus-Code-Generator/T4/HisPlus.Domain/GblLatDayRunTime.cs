using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblLatDayRunTime : EntityBase<int>
    {
        public GblLatDayRunTime()
        {    
        }

        public System.DateTime? LastTime { get; set; }
    }
}
