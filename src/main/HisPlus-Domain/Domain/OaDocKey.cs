using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OaDocKey : EntityBase<int>
    {
        public OaDocKey()
        {    
        }

        public int? DocId { get; set; }
        public string WordKey { get; set; }
    }
}
