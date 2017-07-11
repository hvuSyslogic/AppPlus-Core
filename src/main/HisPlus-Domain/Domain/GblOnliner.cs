using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblOnliner : EntityBase<int>
    {
        public GblOnliner()
        {    
        }

        public int UserId { get; set; }
        public string WorkStationName { get; set; }
        public string LockIp { get; set; }
        public System.DateTime LoginTime { get; set; }
    }
}
