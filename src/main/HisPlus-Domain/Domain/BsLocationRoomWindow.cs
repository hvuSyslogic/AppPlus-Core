using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsLocationRoomWindow : EntityBase<int>
    {
        public BsLocationRoomWindow()
        {    
        }

        public int LocationId { get; set; }
        public string RoomWindowName { get; set; }
        public string PrinterName { get; set; }
    }
}
