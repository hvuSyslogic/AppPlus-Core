using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class RmApplbackDTO : DtoBase<int>
    {
        public RmApplbackDTO()
        {
        }

        public string BillNo { get; set; }
        public int HouseId { get; set; }
        public int RoomId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsAffirm { get; set; }
        public System.DateTime? AffirmTime { get; set; }
        public int? AffirmOperid { get; set; }
        public bool IsSign { get; set; }
        public System.DateTime? SignTime { get; set; }
        public int? SignOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
