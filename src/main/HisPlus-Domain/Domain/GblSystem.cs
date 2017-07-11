using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblSystem : EntityBase<int>
    {
        public GblSystem()
        {    
        }

        public string Name { get; set; }
        public short? OrderBy { get; set; }
        public bool? IsActive { get; set; }
        public short IconIndex { get; set; }
    }
}
