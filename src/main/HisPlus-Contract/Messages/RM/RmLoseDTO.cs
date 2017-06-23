using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class RmLoseDTO : DtoBase<int>
    {
        public RmLoseDTO()
        {
        }

        public string BillNo { get; set; }
        public int RoomId { get; set; }
        public int? LocationId { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int Operid { get; set; }
        public bool IsSign { get; set; }
        public System.DateTime? SignDate { get; set; }
        public int? SignOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
