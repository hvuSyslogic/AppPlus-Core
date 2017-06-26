using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
