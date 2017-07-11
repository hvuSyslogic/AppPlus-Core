using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsLocSystemSub2 : EntityBase<int>
    {
        public BsLocSystemSub2()
        {    
        }

        public int SubId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
    }
}
