using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsInvInItem : EntityBase<int>
    {
        public BsInvInItem()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string GroupName { get; set; }
        public short IconIndex { get; set; }
        public short? GroupOrderBy { get; set; }
    }
}
