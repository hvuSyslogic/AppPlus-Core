using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InHosInfo : EntityBase<int>
    {
        public InHosInfo()
        {    
        }

        public string HospNo { get; set; }
        public int PatId { get; set; }
        public string InPatNo { get; set; }
        public string CardNo { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int NTime { get; set; }
        public System.DateTime InTime { get; set; }
        public System.DateTime? OutTime { get; set; }
        public short LsMarriage { get; set; }
        public string BloodGroup { get; set; }
        public string XNo { get; set; }
        public int? CountryId { get; set; }
        public string Residence { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public bool IsOversea { get; set; }
        public System.DateTime? PassTime { get; set; }
        public string IdCardNo { get; set; }
        public string Company { get; set; }
        public string Occupation { get; set; }
        public int? WorktypeId { get; set; }
        public int PatTypeId { get; set; }
        public int? CertificateId { get; set; }
        public short LsInType { get; set; }
        public short LsInWay { get; set; }
        public short LsInIllness { get; set; }
        public int? DocMz { get; set; }
        public int? DoctorId { get; set; }
        public int LocIn { get; set; }
        public int? LocationId { get; set; }
        public int? BedId { get; set; }
        public bool IsYbMt { get; set; }
        public string YbRegNo { get; set; }
        public decimal? ArrearAmount { get; set; }
        public bool IsBaby { get; set; }
        public short? AgeDay { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public string PhoneHome { get; set; }
        public string AddressHome { get; set; }
        public string PostCodeHome { get; set; }
        public string AreaCodeHome { get; set; }
        public string PhoneWork { get; set; }
        public string AddressWork { get; set; }
        public string PostCodeWork { get; set; }
        public string AreaCodeWork { get; set; }
        public string LinkmanName { get; set; }
        public int? RelationId { get; set; }
        public string LinkmanPhone { get; set; }
        public string LinkmanAddress { get; set; }
        public string LinkmanPost { get; set; }
        public string LinkmanArea { get; set; }
        public short LsInStatus { get; set; }
        public System.DateTime? LeaveTime { get; set; }
        public string Status { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsEndChg { get; set; }
        public int? EndChgOperId { get; set; }
        public System.DateTime? EndchgoperTime { get; set; }
        public string Memo { get; set; }
        public int? MotherHospId { get; set; }
        public int? FromHospitalId { get; set; }
        public int? MzRegId { get; set; }
        public int? LocOut { get; set; }
        public string TipsNurse { get; set; }
        public string TipsBalance { get; set; }
        public string TipsOther { get; set; }
        public string OtherRoles { get; set; }
        public bool? IsIllegal { get; set; }
        public decimal? UnLines { get; set; }
        public decimal? Scale { get; set; }
        public string FromHospital { get; set; }
        public int? Number1 { get; set; }
        public int? Number2 { get; set; }
        public int? Number3 { get; set; }
        public int? Number4 { get; set; }
        public string YbbzCode { get; set; }
        public bool? AmountAuth { get; set; }
        public string Author { get; set; }
        public string AgeStr { get; set; }
        public short? Age { get; set; }
    }
}
