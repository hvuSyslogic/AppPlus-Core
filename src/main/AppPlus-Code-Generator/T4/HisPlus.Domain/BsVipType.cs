using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsVipType : EntityBase<int>
    {
        public BsVipType()
        {    
        }

        public string Name { get; set; }
        public int? OrderBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
