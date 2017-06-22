using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblCurrentUserDTO : DtoBase<int>
    {
        public GblCurrentUserDTO()
        {
        }

        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
        public int? HouseId { get; set; }
        public int? RoomId { get; set; }
        public int? LocationId { get; set; }
        public int? DoctorId { get; set; }
        public string Hostname { get; set; }
        public int? SpecialityId { get; set; }
        public System.DateTime? BeginTime { get; set; }
        public System.DateTime? EndTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
