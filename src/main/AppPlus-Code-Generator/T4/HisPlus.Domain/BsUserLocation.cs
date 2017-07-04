using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsUserLocation : EntityBase<int>
    {
        public BsUserLocation()
        {    
        }

        public int OperId { get; set; }
        public int LocationId { get; set; }
        public short IconIndex { get; set; }
    }
}
