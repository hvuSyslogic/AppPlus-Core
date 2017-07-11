using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblEmailUser : EntityBase<int>
    {
        public GblEmailUser()
        {    
        }

        public int EmailId { get; set; }
        public int OperId { get; set; }
        public bool? IsRead { get; set; }
        public System.DateTime? ReadTime { get; set; }
    }
}
