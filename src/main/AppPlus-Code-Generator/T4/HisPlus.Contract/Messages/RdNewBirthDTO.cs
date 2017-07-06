using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RdNewBirthDTO : DtoBase<int>
    {
        public RdNewBirthDTO()
        {
        }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public int? ProvinceId { get; set; }

        [DataMember]
        public int? RegionId { get; set; }

        [DataMember]
        public int? AreaId { get; set; }

        [DataMember]
        public int? CommitteeId { get; set; }

        [DataMember]
        public int? FamilyId { get; set; }

        [DataMember]
        public short? LsStatus { get; set; }

        [DataMember]
        public short? Weight { get; set; }

        [DataMember]
        public short? Height { get; set; }

        [DataMember]
        public string MotherName { get; set; }

        [DataMember]
        public string FatherName { get; set; }

        [DataMember]
        public short? LsBornPlace { get; set; }

        [DataMember]
        public string OtherPlace { get; set; }

        [DataMember]
        public string DeliverOrgan { get; set; }

        [DataMember]
        public string SignOrgan { get; set; }

        [DataMember]
        public System.DateTime? SignDate { get; set; }

        [DataMember]
        public string Midwife { get; set; }

        [DataMember]
        public bool? IsDanger { get; set; }

        [DataMember]
        public bool? IsCure { get; set; }

        [DataMember]
        public bool? IsFilter { get; set; }

        [DataMember]
        public int? ChildBirthId { get; set; }

        [DataMember]
        public string MotherAge { get; set; }

        [DataMember]
        public string MotherIdCard { get; set; }

        [DataMember]
        public string MotherNation { get; set; }

        [DataMember]
        public string MotherCountry { get; set; }

        [DataMember]
        public string FatherIdCard { get; set; }

        [DataMember]
        public string Weeks { get; set; }

        [DataMember]
        public string FatherAge { get; set; }

        [DataMember]
        public int? Fathercountryid { get; set; }

        [DataMember]
        public int? Fathernationid { get; set; }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public int? BirthResult { get; set; }

        [DataMember]
        public int? BirthStyle { get; set; }

        [DataMember]
        public int? BirthStifle { get; set; }
    }
}
