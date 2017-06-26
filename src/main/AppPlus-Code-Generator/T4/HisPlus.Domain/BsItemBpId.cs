using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
