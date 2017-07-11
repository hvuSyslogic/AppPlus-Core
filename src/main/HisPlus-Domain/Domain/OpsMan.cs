using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OpsMan : EntityBase<int>
    {
        public OpsMan()
        {    
        }

        public int ApplyId { get; set; }
        public int UserId { get; set; }
        public short LsRole { get; set; }
        public int? LocationId { get; set; }
        public int? DocLevId { get; set; }
        public string Memo { get; set; }
    }
}
