using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsPatientDTO : DtoBase<int>
    {
        public BsPatientDTO()
        {
        }

        [DataMember]
        public string InPatNo { get; set; }

        [DataMember]
        public string CardNo { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Sex { get; set; }

        [DataMember]
        public System.DateTime? BirthDate { get; set; }

        [DataMember]
        public short LsMarriage { get; set; }

        [DataMember]
        public string BloodGroup { get; set; }

        [DataMember]
        public string XNo { get; set; }

        [DataMember]
        public int? NationId { get; set; }

        [DataMember]
        public int? CountryId { get; set; }

        [DataMember]
        public int? ProvinceId { get; set; }

        [DataMember]
        public int? RegionId { get; set; }

        [DataMember]
        public int? AreaId { get; set; }

        [DataMember]
        public string Native { get; set; }

        [DataMember]
        public string Residence { get; set; }

        [DataMember]
        public bool IsOversea { get; set; }

        [DataMember]
        public System.DateTime? PassTime { get; set; }

        [DataMember]
        public string Company { get; set; }

        [DataMember]
        public string Occupation { get; set; }

        [DataMember]
        public string Mobile { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public int? WorktypeId { get; set; }

        [DataMember]
        public int? PatTypeId { get; set; }

        [DataMember]
        public int? CertificateId { get; set; }

        [DataMember]
        public string Sensitive { get; set; }

        [DataMember]
        public string IdCardNo { get; set; }

        [DataMember]
        public bool IsBaby { get; set; }

        [DataMember]
        public int? MotherPatId { get; set; }

        [DataMember]
        public string MedicareNo { get; set; }

        [DataMember]
        public string AccountNo { get; set; }

        [DataMember]
        public string PhoneWork { get; set; }

        [DataMember]
        public string AddressWork { get; set; }

        [DataMember]
        public string PostCodeWork { get; set; }

        [DataMember]
        public string AreaCodeWork { get; set; }

        [DataMember]
        public string PhoneHome { get; set; }

        [DataMember]
        public string AddressHome { get; set; }

        [DataMember]
        public string PostCodeHome { get; set; }

        [DataMember]
        public string AreaCodeHome { get; set; }

        [DataMember]
        public string LinkmanName { get; set; }

        [DataMember]
        public int? RelationId { get; set; }

        [DataMember]
        public string LinkmanPost { get; set; }

        [DataMember]
        public string LinkmanArea { get; set; }

        [DataMember]
        public string LinkmanAddress { get; set; }

        [DataMember]
        public string LinkmanPhone { get; set; }

        [DataMember]
        public int? FamilyId { get; set; }

        [DataMember]
        public bool IsHouseMaster { get; set; }

        [DataMember]
        public int? RelaMasterId { get; set; }

        [DataMember]
        public short LsCensus { get; set; }

        [DataMember]
        public int? CommitteeId { get; set; }

        [DataMember]
        public int? PoliceStationId { get; set; }

        [DataMember]
        public int? LevelId { get; set; }

        [DataMember]
        public decimal? Height { get; set; }

        [DataMember]
        public decimal? Weight { get; set; }

        [DataMember]
        public short Circumference { get; set; }

        [DataMember]
        public short Waistline { get; set; }

        [DataMember]
        public short Sternline { get; set; }

        [DataMember]
        public short LsSport { get; set; }

        [DataMember]
        public short LsSportTime { get; set; }

        [DataMember]
        public short LsSportType { get; set; }

        [DataMember]
        public short LsBitHabit { get; set; }

        [DataMember]
        public short SleepHour { get; set; }

        [DataMember]
        public short LsSleepTrouble { get; set; }

        [DataMember]
        public string SmokeHistory { get; set; }

        [DataMember]
        public string DrinkHistory { get; set; }

        [DataMember]
        public string OtherHabit { get; set; }

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
        public short IconIndex { get; set; }

        [DataMember]
        public string PhotoFolder { get; set; }

        [DataMember]
        public int? RoadId { get; set; }

        [DataMember]
        public string PersonHistory { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string HealthCardNo { get; set; }

        [DataMember]
        public string AgeStr { get; set; }

        [DataMember]
        public short? Age { get; set; }
    }
}
