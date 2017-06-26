using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class RdNewBirth : EntityBase<int>
    {
        public RdNewBirth()
        {    
        }

        public int PatId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Code { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? ProvinceId { get; set; }
        public int? RegionId { get; set; }
        public int? AreaId { get; set; }
        public int? CommitteeId { get; set; }
        public int? FamilyId { get; set; }
        public short? LsStatus { get; set; }
        public short? Weight { get; set; }
        public short? Height { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public short? LsBornPlace { get; set; }
        public string OtherPlace { get; set; }
        public string DeliverOrgan { get; set; }
        public string SignOrgan { get; set; }
        public System.DateTime? SignDate { get; set; }
        public string Midwife { get; set; }
        public bool? IsDanger { get; set; }
        public bool? IsCure { get; set; }
        public bool? IsFilter { get; set; }
        public int? ChildBirthId { get; set; }
        public string MotherAge { get; set; }
        public string MotherIdCard { get; set; }
        public string MotherNation { get; set; }
        public string MotherCountry { get; set; }
        public string FatherIdCard { get; set; }
        public string Weeks { get; set; }
        public string FatherAge { get; set; }
        public int? Fathercountryid { get; set; }
        public int? Fathernationid { get; set; }
        public int? HospId { get; set; }
        public int? BirthResult { get; set; }
        public int? BirthStyle { get; set; }
        public int? BirthStifle { get; set; }
    }
}
