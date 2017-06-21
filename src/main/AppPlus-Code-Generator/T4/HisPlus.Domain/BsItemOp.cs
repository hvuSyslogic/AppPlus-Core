using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    // The table 'BsItemOps' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class BsItemOp
    {
        public BsItemOp()
        {    
        }

        public string TypeName { get; set; }
        public int? ItemId { get; set; }
    }
}
