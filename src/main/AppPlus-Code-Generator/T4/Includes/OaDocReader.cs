using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
