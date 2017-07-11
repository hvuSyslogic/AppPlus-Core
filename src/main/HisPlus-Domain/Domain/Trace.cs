using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class Trace : EntityBase<int>
    {
        public Trace()
        {    
        }

        public System.DateTime CreateDate { get; set; }
        public int UserId { get; set; }
        public string Ip { get; set; }
        public string Messages { get; set; }
        public string Type { get; set; }
        public string OperateType { get; set; }
        public int? RecordId { get; set; }
    }
}
