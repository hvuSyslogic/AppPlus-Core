using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OaDocReader : EntityBase<int>
    {
        public OaDocReader()
        {    
        }

        public int? DocId { get; set; }
        public int? AllowOperId { get; set; }
        public System.DateTime? ExpireTime { get; set; }
    }
}
