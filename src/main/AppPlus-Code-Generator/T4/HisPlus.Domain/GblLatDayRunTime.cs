using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class GblLatDayRunTime : EntityBase<int>
    {
        public GblLatDayRunTime()
        {    
        }

        public System.DateTime? LastTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
