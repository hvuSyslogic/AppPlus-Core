using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

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
    }
}
