using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsItemPatType : EntityBase<int>
    {
        public BsItemPatType()
        {    
        }

        public int PatTypeId { get; set; }
        public int ItemId { get; set; }
        public decimal DiscDiag { get; set; }
        public decimal DiscIn { get; set; }
        public int InvMzItemId { get; set; }
        public int InvInItemId { get; set; }
        public int? LimitGroupId { get; set; }
        public short IconIndex { get; set; }
    }
}
