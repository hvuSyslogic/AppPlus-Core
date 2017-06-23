using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class OuDocRegTypeDTO : DtoBase<int>
    {
        public OuDocRegTypeDTO()
        {
        }

        public System.DateTime RegDate { get; set; }
        public int? WeekPlanId { get; set; }
        public int DoctorId { get; set; }
        public int RegTypeId { get; set; }
        public int TimeSpanId { get; set; }
        public int LocationId { get; set; }
        public int? DiagRoomId { get; set; }
        public short? LimitNum { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? Iscancel { get; set; }
        public int? Lastlimitnum { get; set; }
    }
}
