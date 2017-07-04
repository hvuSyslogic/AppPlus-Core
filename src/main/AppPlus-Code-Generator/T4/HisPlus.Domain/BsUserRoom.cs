using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsUserRoom : EntityBase<int>
    {
        public BsUserRoom()
        {    
        }

        public int OperId { get; set; }
        public int RoomId { get; set; }
        public short IconIndex { get; set; }
    }
}
