using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class RmCheckDTO : DtoBase<int>
    {
        public RmCheckDTO()
        {
        }

        public string BillNo { get; set; }
        public int RoomId { get; set; }
        public System.DateTime? CheckTime { get; set; }
        public decimal CheckAmount { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
