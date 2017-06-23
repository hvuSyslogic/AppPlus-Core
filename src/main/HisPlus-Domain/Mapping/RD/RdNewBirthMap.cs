using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RdNewBirthMap : EntityTypeConfiguration<RdNewBirth>
    {
        public RdNewBirthMap()
            : this("dbo")
        {
        }

        public RdNewBirthMap(string schema)
        {
            ToTable("RdNewBirth", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(12);
            Property(x => x.F1).HasColumnName(@"F1").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.ProvinceId).HasColumnName(@"ProvinceId").IsOptional().HasColumnType("int");
            Property(x => x.RegionId).HasColumnName(@"RegionId").IsOptional().HasColumnType("int");
            Property(x => x.AreaId).HasColumnName(@"AreaId").IsOptional().HasColumnType("int");
            Property(x => x.CommitteeId).HasColumnName(@"CommitteeId").IsOptional().HasColumnType("int");
            Property(x => x.FamilyId).HasColumnName(@"FamilyId").IsOptional().HasColumnType("int");
            Property(x => x.LsStatus).HasColumnName(@"LsStatus").IsOptional().HasColumnType("smallint");
            Property(x => x.Weight).HasColumnName(@"Weight").IsOptional().HasColumnType("smallint");
            Property(x => x.Height).HasColumnName(@"Height").IsOptional().HasColumnType("smallint");
            Property(x => x.MotherName).HasColumnName(@"MotherName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.FatherName).HasColumnName(@"FatherName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsBornPlace).HasColumnName(@"LsBornPlace").IsOptional().HasColumnType("smallint");
            Property(x => x.OtherPlace).HasColumnName(@"OtherPlace").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.DeliverOrgan).HasColumnName(@"DeliverOrgan").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.SignOrgan).HasColumnName(@"SignOrgan").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.SignDate).HasColumnName(@"SignDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.Midwife).HasColumnName(@"Midwife").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsDanger).HasColumnName(@"IsDanger").IsOptional().HasColumnType("bit");
            Property(x => x.IsCure).HasColumnName(@"IsCure").IsOptional().HasColumnType("bit");
            Property(x => x.IsFilter).HasColumnName(@"IsFilter").IsOptional().HasColumnType("bit");
            Property(x => x.ChildBirthId).HasColumnName(@"ChildBirthId").IsOptional().HasColumnType("int");
            Property(x => x.MotherAge).HasColumnName(@"MotherAge").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.MotherIdCard).HasColumnName(@"MotherIdCard").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.MotherNation).HasColumnName(@"MotherNation").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.MotherCountry).HasColumnName(@"MotherCountry").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.FatherIdCard).HasColumnName(@"FatherIdCard").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Weeks).HasColumnName(@"Weeks").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.FatherAge).HasColumnName(@"FatherAge").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Fathercountryid).HasColumnName(@"Fathercountryid").IsOptional().HasColumnType("int");
            Property(x => x.Fathernationid).HasColumnName(@"Fathernationid").IsOptional().HasColumnType("int");
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.BirthResult).HasColumnName(@"BirthResult").IsOptional().HasColumnType("int");
            Property(x => x.BirthStyle).HasColumnName(@"BirthStyle").IsOptional().HasColumnType("int");
            Property(x => x.BirthStifle).HasColumnName(@"BirthStifle").IsOptional().HasColumnType("int");
        }
    }
}
