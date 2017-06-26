using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsFamilyDTO : DtoBase<int>
    {
        public BsFamilyDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public int CommitteeId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string AddressHome { get; set; }

        [DataMember]
        public string PhoneHome { get; set; }

        [DataMember]
        public string PostCodeHome { get; set; }

        [DataMember]
        public string AreaCodeHome { get; set; }

        [DataMember]
        public short TotalPersons { get; set; }

        [DataMember]
        public short HousePersons { get; set; }

        [DataMember]
        public short WorkingPersons { get; set; }

        [DataMember]
        public short LsFamilyType { get; set; }

        [DataMember]
        public short LsPeriod { get; set; }

        [DataMember]
        public short LsHouseType { get; set; }

        [DataMember]
        public short Acreage { get; set; }

        [DataMember]
        public short LsFuel { get; set; }

        [DataMember]
        public short LsWarm { get; set; }

        [DataMember]
        public short LsCold { get; set; }

        [DataMember]
        public short LsWater { get; set; }

        [DataMember]
        public short LsSaniFamily { get; set; }

        [DataMember]
        public short LsSaniPerson { get; set; }

        [DataMember]
        public short LsSaniHabit { get; set; }

        [DataMember]
        public short LsNeighbourhood { get; set; }

        [DataMember]
        public short LsWc { get; set; }

        [DataMember]
        public bool IsHealthBin { get; set; }

        [DataMember]
        public short LsIncome { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public string InActiveReason { get; set; }

        [DataMember]
        public System.DateTime? InActiveTime { get; set; }

        [DataMember]
        public int? InActiveOperId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public short IconIndex { get; set; }

        [DataMember]
        public int? RoadId { get; set; }

        [DataMember]
        public bool? IsSign { get; set; }

        [DataMember]
        public short? IsCareMan { get; set; }

        [DataMember]
        public int? SignDoctorId { get; set; }

        [DataMember]
        public int? SignGroupId { get; set; }
    }
}
