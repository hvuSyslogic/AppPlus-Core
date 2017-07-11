using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblElGroup : EntityBase<int>
    {
        public GblElGroup()
        {    
        }

        public short? LsType { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public short? OrderBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
