using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsLocSystem : EntityBase<int>
    {
        public BsLocSystem()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
    }
}
