using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsNew : EntityBase<int>
    {
        public BsNew()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
        public string GroupMian { get; set; }
    }
}
