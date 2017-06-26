using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsPatientMap : EntityTypeConfiguration<BsPatient>
    {
        public BsPatientMap()
            : this("dbo")
        {
        }

        public BsPatientMap(string schema)
        {
            ToTable("BsPatient", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.InPatNo).HasColumnName(@"InPatNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(13);
            Property(x => x.CardNo).HasColumnName(@"CardNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(19);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Sex).HasColumnName(@"Sex").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.BirthDate).HasColumnName(@"BirthDate").IsOptional().HasColumnType("datetime");
            Property(x => x.LsMarriage).HasColumnName(@"LsMarriage").IsRequired().HasColumnType("smallint");
            Property(x => x.BloodGroup).HasColumnName(@"BloodGroup").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.XNo).HasColumnName(@"XNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.NationId).HasColumnName(@"NationId").IsOptional().HasColumnType("int");
            Property(x => x.CountryId).HasColumnName(@"CountryId").IsOptional().HasColumnType("int");
            Property(x => x.ProvinceId).HasColumnName(@"ProvinceId").IsOptional().HasColumnType("int");
            Property(x => x.RegionId).HasColumnName(@"RegionId").IsOptional().HasColumnType("int");
            Property(x => x.AreaId).HasColumnName(@"AreaId").IsOptional().HasColumnType("int");
            Property(x => x.Native).HasColumnName(@"Native").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Residence).HasColumnName(@"Residence").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IsOversea).HasColumnName(@"IsOversea").IsRequired().HasColumnType("bit");
            Property(x => x.PassTime).HasColumnName(@"PassTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.Company).HasColumnName(@"Company").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Occupation).HasColumnName(@"Occupation").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Mobile).HasColumnName(@"Mobile").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.Email).HasColumnName(@"Email").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Phone).HasColumnName(@"Phone").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.WorktypeId).HasColumnName(@"WorktypeId").IsOptional().HasColumnType("int");
            Property(x => x.PatTypeId).HasColumnName(@"PatTypeId").IsOptional().HasColumnType("int");
            Property(x => x.CertificateId).HasColumnName(@"CertificateId").IsOptional().HasColumnType("int");
            Property(x => x.Sensitive).HasColumnName(@"Sensitive").IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.IdCardNo).HasColumnName(@"IdCardNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsBaby).HasColumnName(@"isBaby").IsRequired().HasColumnType("bit");
            Property(x => x.MotherPatId).HasColumnName(@"MotherPatId").IsOptional().HasColumnType("int");
            Property(x => x.MedicareNo).HasColumnName(@"MedicareNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(18);
            Property(x => x.AccountNo).HasColumnName(@"AccountNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(13);
            Property(x => x.PhoneWork).HasColumnName(@"PhoneWork").IsRequired().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.AddressWork).HasColumnName(@"AddressWork").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PostCodeWork).HasColumnName(@"PostCodeWork").IsRequired().HasColumnType("nvarchar").HasMaxLength(7);
            Property(x => x.AreaCodeWork).HasColumnName(@"AreaCodeWork").IsRequired().HasColumnType("nvarchar").HasMaxLength(5);
            Property(x => x.PhoneHome).HasColumnName(@"PhoneHome").IsRequired().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.AddressHome).HasColumnName(@"AddressHome").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PostCodeHome).HasColumnName(@"PostCodeHome").IsRequired().HasColumnType("nvarchar").HasMaxLength(7);
            Property(x => x.AreaCodeHome).HasColumnName(@"AreaCodeHome").IsRequired().HasColumnType("nvarchar").HasMaxLength(5);
            Property(x => x.LinkmanName).HasColumnName(@"LinkmanName").IsRequired().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.RelationId).HasColumnName(@"RelationId").IsOptional().HasColumnType("int");
            Property(x => x.LinkmanPost).HasColumnName(@"LinkmanPost").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.LinkmanArea).HasColumnName(@"LinkmanArea").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.LinkmanAddress).HasColumnName(@"LinkmanAddress").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.LinkmanPhone).HasColumnName(@"LinkmanPhone").IsRequired().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.FamilyId).HasColumnName(@"FamilyId").IsOptional().HasColumnType("int");
            Property(x => x.IsHouseMaster).HasColumnName(@"isHouseMaster").IsRequired().HasColumnType("bit");
            Property(x => x.RelaMasterId).HasColumnName(@"RelaMasterId").IsOptional().HasColumnType("int");
            Property(x => x.LsCensus).HasColumnName(@"LsCensus").IsRequired().HasColumnType("smallint");
            Property(x => x.CommitteeId).HasColumnName(@"CommitteeId").IsOptional().HasColumnType("int");
            Property(x => x.PoliceStationId).HasColumnName(@"PoliceStationId").IsOptional().HasColumnType("int");
            Property(x => x.LevelId).HasColumnName(@"LevelId").IsOptional().HasColumnType("int");
            Property(x => x.Height).HasColumnName(@"Height").IsOptional().HasColumnType("numeric").HasPrecision(5,2);
            Property(x => x.Weight).HasColumnName(@"Weight").IsOptional().HasColumnType("numeric").HasPrecision(5,2);
            Property(x => x.Circumference).HasColumnName(@"Circumference").IsRequired().HasColumnType("smallint");
            Property(x => x.Waistline).HasColumnName(@"Waistline").IsRequired().HasColumnType("smallint");
            Property(x => x.Sternline).HasColumnName(@"Sternline").IsRequired().HasColumnType("smallint");
            Property(x => x.LsSport).HasColumnName(@"LsSport").IsRequired().HasColumnType("smallint");
            Property(x => x.LsSportTime).HasColumnName(@"LsSportTime").IsRequired().HasColumnType("smallint");
            Property(x => x.LsSportType).HasColumnName(@"LsSportType").IsRequired().HasColumnType("smallint");
            Property(x => x.LsBitHabit).HasColumnName(@"LsBitHabit").IsRequired().HasColumnType("smallint");
            Property(x => x.SleepHour).HasColumnName(@"SleepHour").IsRequired().HasColumnType("smallint");
            Property(x => x.LsSleepTrouble).HasColumnName(@"LsSleepTrouble").IsRequired().HasColumnType("smallint");
            Property(x => x.SmokeHistory).HasColumnName(@"SmokeHistory").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.DrinkHistory).HasColumnName(@"DrinkHistory").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.OtherHabit).HasColumnName(@"OtherHabit").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.InActiveReason).HasColumnName(@"InActiveReason").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.InActiveTime).HasColumnName(@"InActiveTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.InActiveOperId).HasColumnName(@"InActiveOperID").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.PhotoFolder).HasColumnName(@"PhotoFolder").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.RoadId).HasColumnName(@"RoadId").IsOptional().HasColumnType("int");
            Property(x => x.PersonHistory).HasColumnName(@"PersonHistory").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Password).HasColumnName(@"Password").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.HealthCardNo).HasColumnName(@"HealthCardNo").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
