using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsDoctor : EntityBase<int>
    {
        public BsDoctor()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public System.DateTime? BirthDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int? LevelId { get; set; }
        public int? DocLevId { get; set; }
        public string Introduce { get; set; }
        public int? LocationId { get; set; }
        public int? RegTypeId { get; set; }
        public string PicturePath { get; set; }
        public short LsStatus { get; set; }
        public short OrderBy { get; set; }
        public short IconIndex { get; set; }
        public int? UserId { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public int? SupDoctorId { get; set; }
        public int? DiagRoomId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public bool? IsPoisonMa { get; set; }
        public bool? IsRecipe { get; set; }
        public short? Grade { get; set; }
        public bool? IsConsult { get; set; }
    }
}
