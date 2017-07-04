using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InHosInfoMap : EntityTypeConfiguration<InHosInfo>
    {
        public InHosInfoMap()
            : this("dbo")
        {
        }

        public InHosInfoMap(string schema)
        {
            ToTable("InHosInfo", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospNo).HasColumnName(@"HospNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.PatId).HasColumnName(@"PatID").IsRequired().HasColumnType("int");
            Property(x => x.InPatNo).HasColumnName(@"InPatNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(13);
            Property(x => x.CardNo).HasColumnName(@"CardNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(19);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Sex).HasColumnName(@"Sex").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.NTime).HasColumnName(@"NTime").IsRequired().HasColumnType("int");
            Property(x => x.InTime).HasColumnName(@"InTime").IsRequired().HasColumnType("datetime");
            Property(x => x.OutTime).HasColumnName(@"OutTime").IsOptional().HasColumnType("datetime");
            Property(x => x.LsMarriage).HasColumnName(@"LsMarriage").IsRequired().HasColumnType("smallint");
            Property(x => x.BloodGroup).HasColumnName(@"BloodGroup").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.XNo).HasColumnName(@"XNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.CountryId).HasColumnName(@"CountryId").IsOptional().HasColumnType("int");
            Property(x => x.Residence).HasColumnName(@"Residence").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.City).HasColumnName(@"City").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Province).HasColumnName(@"Province").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsOversea).HasColumnName(@"IsOversea").IsRequired().HasColumnType("bit");
            Property(x => x.PassTime).HasColumnName(@"PassTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.IdCardNo).HasColumnName(@"IdCardNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Company).HasColumnName(@"Company").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Occupation).HasColumnName(@"Occupation").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.WorktypeId).HasColumnName(@"WorktypeId").IsOptional().HasColumnType("int");
            Property(x => x.PatTypeId).HasColumnName(@"PatTypeId").IsRequired().HasColumnType("int");
            Property(x => x.CertificateId).HasColumnName(@"CertificateId").IsOptional().HasColumnType("int");
            Property(x => x.LsInType).HasColumnName(@"LsInType").IsRequired().HasColumnType("smallint");
            Property(x => x.LsInWay).HasColumnName(@"LsInWay").IsRequired().HasColumnType("smallint");
            Property(x => x.LsInIllness).HasColumnName(@"LsInIllness").IsRequired().HasColumnType("smallint");
            Property(x => x.DocMz).HasColumnName(@"DocMz").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.LocIn).HasColumnName(@"LocIn").IsRequired().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.BedId).HasColumnName(@"BedId").IsOptional().HasColumnType("int");
            Property(x => x.IsYbMt).HasColumnName(@"IsYbMt").IsRequired().HasColumnType("bit");
            Property(x => x.YbRegNo).HasColumnName(@"YbRegNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ArrearAmount).HasColumnName(@"ArrearAmount").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.IsBaby).HasColumnName(@"IsBaby").IsRequired().HasColumnType("bit");
            Property(x => x.AgeDay).HasColumnName(@"AgeDay").IsOptional().HasColumnType("smallint");
            Property(x => x.Height).HasColumnName(@"Height").IsOptional().HasColumnType("numeric").HasPrecision(5,2);
            Property(x => x.Weight).HasColumnName(@"Weight").IsOptional().HasColumnType("numeric").HasPrecision(5,2);
            Property(x => x.PhoneHome).HasColumnName(@"PhoneHome").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.AddressHome).HasColumnName(@"AddressHome").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PostCodeHome).HasColumnName(@"PostCodeHome").IsRequired().HasColumnType("nvarchar").HasMaxLength(7);
            Property(x => x.AreaCodeHome).HasColumnName(@"AreaCodeHome").IsRequired().HasColumnType("nvarchar").HasMaxLength(5);
            Property(x => x.PhoneWork).HasColumnName(@"PhoneWork").IsRequired().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.AddressWork).HasColumnName(@"AddressWork").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PostCodeWork).HasColumnName(@"PostCodeWork").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.AreaCodeWork).HasColumnName(@"AreaCodeWork").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LinkmanName).HasColumnName(@"LinkmanName").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.RelationId).HasColumnName(@"RelationId").IsOptional().HasColumnType("int");
            Property(x => x.LinkmanPhone).HasColumnName(@"LinkmanPhone").IsRequired().HasColumnType("nvarchar").HasMaxLength(25);
            Property(x => x.LinkmanAddress).HasColumnName(@"LinkmanAddress").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.LinkmanPost).HasColumnName(@"LinkmanPost").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.LinkmanArea).HasColumnName(@"LinkmanArea").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.LsInStatus).HasColumnName(@"LsInStatus").IsRequired().HasColumnType("smallint");
            Property(x => x.LeaveTime).HasColumnName(@"LeaveTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.Status).HasColumnName(@"Status").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.IsEndChg).HasColumnName(@"IsEndChg").IsRequired().HasColumnType("bit");
            Property(x => x.EndChgOperId).HasColumnName(@"EndChgOperID").IsOptional().HasColumnType("int");
            Property(x => x.EndchgoperTime).HasColumnName(@"EndchgoperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.MotherHospId).HasColumnName(@"MotherHospId").IsOptional().HasColumnType("int");
            Property(x => x.FromHospitalId).HasColumnName(@"FromHospitalId").IsOptional().HasColumnType("int");
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsOptional().HasColumnType("int");
            Property(x => x.LocOut).HasColumnName(@"LocOut").IsOptional().HasColumnType("int");
            Property(x => x.TipsNurse).HasColumnName(@"TipsNurse").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.TipsBalance).HasColumnName(@"TipsBalance").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.TipsOther).HasColumnName(@"TipsOther").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.OtherRoles).HasColumnName(@"OtherRoles").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsIllegal).HasColumnName(@"IsIllegal").IsOptional().HasColumnType("bit");
            Property(x => x.UnLines).HasColumnName(@"UnLines").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Scale).HasColumnName(@"Scale").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.FromHospital).HasColumnName(@"FromHospital").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.Number1).HasColumnName(@"NUMBER1").IsOptional().HasColumnType("int");
            Property(x => x.Number2).HasColumnName(@"NUMBER2").IsOptional().HasColumnType("int");
            Property(x => x.Number3).HasColumnName(@"NUMBER3").IsOptional().HasColumnType("int");
            Property(x => x.Number4).HasColumnName(@"NUMBER4").IsOptional().HasColumnType("int");
            Property(x => x.YbbzCode).HasColumnName(@"YBBZCode").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.AmountAuth).HasColumnName(@"AmountAuth").IsOptional().HasColumnType("bit");
            Property(x => x.Author).HasColumnName(@"Author").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.AgeStr).HasColumnName(@"AgeStr").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Age).HasColumnName(@"Age").IsOptional().HasColumnType("smallint");
        }
    }
}
