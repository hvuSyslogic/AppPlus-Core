using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
