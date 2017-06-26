using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsItemIllType : EntityBase<int>
    {
        public BsItemIllType()
        {    
        }

        public int ItemId { get; set; }
        public int IllTypeId { get; set; }
        public string YbCode { get; set; }
        public int? TallyGroupId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
