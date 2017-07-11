using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkProfile : EntityBase<int>
    {
        public CkProfile()
        {    
        }

        public int ProfileId { get; set; }
        public int TestId { get; set; }
        public int? ItemId { get; set; }
        public int? SourceId { get; set; }
        public int? TubeTypeId { get; set; }
    }
}
