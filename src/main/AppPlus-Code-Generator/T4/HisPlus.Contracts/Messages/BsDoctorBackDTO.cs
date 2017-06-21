using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsDoctorBackDTO : DtoBase<int>
    {
        public BsDoctorBackDTO()
        {
        }

        public System.DateTime? BirthDate { get; set; }
        public int? LevelId { get; set; }
        public int? DocLevId { get; set; }
        public int? RegTypeId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? UserId { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public int? SupDoctorId { get; set; }
    }
}
