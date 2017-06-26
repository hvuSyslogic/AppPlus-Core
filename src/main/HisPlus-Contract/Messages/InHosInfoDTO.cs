using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InHosInfoDTO : DtoBase<int>
    {
        public InHosInfoDTO()
        {
        }

        [DataMember]
        public string HospNo { get; set; }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public string InPatNo { get; set; }

        [DataMember]
        public string CardNo { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Sex { get; set; }

        [DataMember]
        public int NTime { get; set; }

        [DataMember]
        public System.DateTime InTime { get; set; }

        [DataMember]
        public System.DateTime? OutTime { get; set; }

        [DataMember]
        public short LsMarriage { get; set; }

        [DataMember]
        public string BloodGroup { get; set; }

        [DataMember]
        public string XNo { get; set; }

        [DataMember]
        public int? CountryId { get; set; }

        [DataMember]
        public string Residence { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Province { get; set; }

        [DataMember]
        public bool IsOversea { get; set; }

        [DataMember]
        public System.DateTime? PassTime { get; set; }

        [DataMember]
        public string IdCardNo { get; set; }

        [DataMember]
        public string Company { get; set; }

        [DataMember]
        public string Occupation { get; set; }

        [DataMember]
        public int? WorktypeId { get; set; }

        [DataMember]
        public int PatTypeId { get; set; }

        [DataMember]
        public int? CertificateId { get; set; }

        [DataMember]
        public short LsInType { get; set; }

        [DataMember]
        public short LsInWay { get; set; }

        [DataMember]
        public short LsInIllness { get; set; }

        [DataMember]
        public int? DocMz { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public int LocIn { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? BedId { get; set; }

        [DataMember]
        public bool IsYbMt { get; set; }

        [DataMember]
        public string YbRegNo { get; set; }

        [DataMember]
        public decimal? ArrearAmount { get; set; }

        [DataMember]
        public bool IsBaby { get; set; }

        [DataMember]
        public short? AgeDay { get; set; }

        [DataMember]
        public decimal? Height { get; set; }

        [DataMember]
        public decimal? Weight { get; set; }

        [DataMember]
        public string PhoneHome { get; set; }

        [DataMember]
        public string AddressHome { get; set; }

        [DataMember]
        public string PostCodeHome { get; set; }

        [DataMember]
        public string AreaCodeHome { get; set; }

        [DataMember]
        public string PhoneWork { get; set; }

        [DataMember]
        public string AddressWork { get; set; }

        [DataMember]
        public string PostCodeWork { get; set; }

        [DataMember]
        public string AreaCodeWork { get; set; }

        [DataMember]
        public string LinkmanName { get; set; }

        [DataMember]
        public int? RelationId { get; set; }

        [DataMember]
        public string LinkmanPhone { get; set; }

        [DataMember]
        public string LinkmanAddress { get; set; }

        [DataMember]
        public string LinkmanPost { get; set; }

        [DataMember]
        public string LinkmanArea { get; set; }

        [DataMember]
        public short LsInStatus { get; set; }

        [DataMember]
        public System.DateTime? LeaveTime { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public bool IsEndChg { get; set; }

        [DataMember]
        public int? EndChgOperId { get; set; }

        [DataMember]
        public System.DateTime? EndchgoperTime { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public int? MotherHospId { get; set; }

        [DataMember]
        public int? FromHospitalId { get; set; }

        [DataMember]
        public int? MzRegId { get; set; }

        [DataMember]
        public int? LocOut { get; set; }

        [DataMember]
        public string TipsNurse { get; set; }

        [DataMember]
        public string TipsBalance { get; set; }

        [DataMember]
        public string TipsOther { get; set; }

        [DataMember]
        public string OtherRoles { get; set; }

        [DataMember]
        public bool? IsIllegal { get; set; }

        [DataMember]
        public decimal? UnLines { get; set; }

        [DataMember]
        public decimal? Scale { get; set; }

        [DataMember]
        public string FromHospital { get; set; }

        [DataMember]
        public int? Number1 { get; set; }

        [DataMember]
        public int? Number2 { get; set; }

        [DataMember]
        public int? Number3 { get; set; }

        [DataMember]
        public int? Number4 { get; set; }

        [DataMember]
        public string F5 { get; set; }

        [DataMember]
        public string F6 { get; set; }

        [DataMember]
        public string F7 { get; set; }

        [DataMember]
        public string F8 { get; set; }

        [DataMember]
        public string YbbzCode { get; set; }

        [DataMember]
        public bool? AmountAuth { get; set; }

        [DataMember]
        public string Author { get; set; }
    }
}
