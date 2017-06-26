using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsFamily : EntityBase<int>
    {
        public BsFamily()
        {    
        }

        public string Code { get; set; }
        public int CommitteeId { get; set; }
        public string Name { get; set; }
        public string AddressHome { get; set; }
        public string PhoneHome { get; set; }
        public string PostCodeHome { get; set; }
        public string AreaCodeHome { get; set; }
        public short TotalPersons { get; set; }
        public short HousePersons { get; set; }
        public short WorkingPersons { get; set; }
        public short LsFamilyType { get; set; }
        public short LsPeriod { get; set; }
        public short LsHouseType { get; set; }
        public short Acreage { get; set; }
        public short LsFuel { get; set; }
        public short LsWarm { get; set; }
        public short LsCold { get; set; }
        public short LsWater { get; set; }
        public short LsSaniFamily { get; set; }
        public short LsSaniPerson { get; set; }
        public short LsSaniHabit { get; set; }
        public short LsNeighbourhood { get; set; }
        public short LsWc { get; set; }
        public bool IsHealthBin { get; set; }
        public short LsIncome { get; set; }
        public string Memo { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsActive { get; set; }
        public string InActiveReason { get; set; }
        public System.DateTime? InActiveTime { get; set; }
        public int? InActiveOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public int? RoadId { get; set; }
        public bool? IsSign { get; set; }
        public short? IsCareMan { get; set; }
        public int? SignDoctorId { get; set; }
        public int? SignGroupId { get; set; }
    }
}
