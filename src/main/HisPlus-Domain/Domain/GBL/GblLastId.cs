using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class GblLastId : EntityBase<int>
    {
        public GblLastId()
        {    
        }

        public string TableName { get; set; }
        public int? LastId { get; set; }
        public System.DateTime? LastTime { get; set; }
    }
}
