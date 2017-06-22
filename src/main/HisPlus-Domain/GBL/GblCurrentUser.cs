using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class GblCurrentUser : EntityBase<int>
    {
        public GblCurrentUser()
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
