using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsItemItem : EntityBase<int>
    {
        public BsItemItem()
        {    
        }

        public int ItemId1 { get; set; }
        public int ItemId2 { get; set; }
        public bool IsReject { get; set; }
        public short IconIndex { get; set; }
    }
}
