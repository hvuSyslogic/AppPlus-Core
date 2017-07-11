using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsItemFirstPage : EntityBase<int>
    {
        public BsItemFirstPage()
        {    
        }

        public int ItemId { get; set; }
        public int? PsFeeId { get; set; }
    }
}
