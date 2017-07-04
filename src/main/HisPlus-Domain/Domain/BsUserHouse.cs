using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsUserHouse : EntityBase<int>
    {
        public BsUserHouse()
        {    
        }

        public int OperId { get; set; }
        public int HouseId { get; set; }
        public short IconIndex { get; set; }
    }
}
