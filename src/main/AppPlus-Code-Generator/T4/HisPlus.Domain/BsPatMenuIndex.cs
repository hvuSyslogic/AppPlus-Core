using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsPatMenuIndex : EntityBase<int>
    {
        public BsPatMenuIndex()
        {    
        }

        public int PatId { get; set; }
        public int PatMenuId { get; set; }
        public string ParentId { get; set; }
        public int RecordId { get; set; }
        public string Tips { get; set; }
    }
}
