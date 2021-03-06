using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsItemYbTip : EntityBase<int>
    {
        public BsItemYbTip()
        {    
        }

        public int ItemId { get; set; }
        public int? PatTypeId { get; set; }
        public int? TallyGroupId { get; set; }
        public int? IcdId { get; set; }
        public string IllDesc { get; set; }
        public string Tips { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
