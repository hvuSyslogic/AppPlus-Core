using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsItemBpId : EntityBase<int>
    {
        public BsItemBpId()
        {    
        }

        public int? BpItemId { get; set; }
        public int? HisItemId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? UserId { get; set; }
    }
}
