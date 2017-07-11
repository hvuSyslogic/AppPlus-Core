using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsLabSourceItem : EntityBase<int>
    {
        public BsLabSourceItem()
        {    
        }

        public int SourceId { get; set; }
        public int? TubeTypeId { get; set; }
        public int ItemId { get; set; }
        public decimal Totality { get; set; }
        public short LsUseArea { get; set; }
    }
}
