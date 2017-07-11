using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblRole : EntityBase<int>
    {
        public GblRole()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public short OrderBy { get; set; }
        public short IconIndex { get; set; }
        public string GroupName { get; set; }
    }
}
