using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsLocation : EntityBase<int>
    {
        public BsLocation()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int? HospitalId { get; set; }
        public short LsInOut { get; set; }
        public bool IsForwomen { get; set; }
        public string PhoneCode { get; set; }
        public decimal MedicineRatio { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
        public int? SpecialityId { get; set; }
        public short? BedSum { get; set; }
        public string BaSysCode { get; set; }
        public string Director { get; set; }
        public int? DeptTypeId { get; set; }
        public bool? IsCostApp { get; set; }
        public int? AppLevel { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public int? Area { get; set; }
        public int? OuRoomId { get; set; }
        public int? InRoomId { get; set; }
        public bool? IsPriceSub { get; set; }
        public bool? IsClinical { get; set; }
        public bool? IsChinLocation { get; set; }
    }
}
