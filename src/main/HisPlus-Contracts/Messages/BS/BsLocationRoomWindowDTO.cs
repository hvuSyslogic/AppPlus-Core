using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsLocationRoomWindowDTO : DtoBase<int>
    {
        public BsLocationRoomWindowDTO()
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
