using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsDocRegTypeDTO : DtoBase<int>
    {
        public BsDocRegTypeDTO()
        {
        }

        public int DoctorId { get; set; }
        public int RegTypeId { get; set; }
        public int LocationId { get; set; }
        public short? LimitNum { get; set; }
        public System.DateTime? LastLimitDate { get; set; }
        public short? LastLimitNum { get; set; }
        public bool? IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short WeekDay { get; set; }
        public int TimeSpanId { get; set; }
        public string RoomNo { get; set; }
        public int? Diagroomid { get; set; }
    }
}
