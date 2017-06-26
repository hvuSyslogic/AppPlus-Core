using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
