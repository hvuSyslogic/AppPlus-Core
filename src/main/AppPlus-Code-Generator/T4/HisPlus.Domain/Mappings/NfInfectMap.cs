using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class NfInfectMap : EntityTypeConfiguration<NfInfect>
    {
        public NfInfectMap()
            : this("dbo")
        {
        }

        public NfInfectMap(string schema)
        {
            ToTable("NfInfect", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LsInfectType).HasColumnName(@"LsInfectType").IsRequired().HasColumnType("smallint");
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(12);
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.LsEffect).HasColumnName(@"LsEffect").IsRequired().HasColumnType("smallint");
            Property(x => x.LsCutType).HasColumnName(@"LsCutType").IsRequired().HasColumnType("smallint");
            Property(x => x.InfectTime).HasColumnName(@"InfectTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.PositionId).HasColumnName(@"PositionId").IsRequired().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsRequired().HasColumnType("int");
            Property(x => x.SpecialityId).HasColumnName(@"SpecialityId").IsRequired().HasColumnType("int");
            Property(x => x.LsInfluence).HasColumnName(@"LsInfluence").IsOptional().HasColumnType("smallint");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.OpsId).HasColumnName(@"OPSId").IsOptional().HasColumnType("int");
            Property(x => x.OpsTime).HasColumnName(@"OPSTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.LsClass).HasColumnName(@"LsClass").IsOptional().HasColumnType("smallint");
            Property(x => x.LsAsa).HasColumnName(@"LsASA").IsOptional().HasColumnType("smallint");
            Property(x => x.IsEmergency).HasColumnName(@"IsEmergency").IsOptional().HasColumnType("bit");
            Property(x => x.AnaesId).HasColumnName(@"AnaesId").IsOptional().HasColumnType("int");
            Property(x => x.Minutes).HasColumnName(@"Minutes").IsOptional().HasColumnType("int");
            Property(x => x.IsImplant).HasColumnName(@"IsImplant").IsOptional().HasColumnType("bit");
            Property(x => x.IsImglass).HasColumnName(@"IsImglass").IsOptional().HasColumnType("bit");
            Property(x => x.IsOpsDrug).HasColumnName(@"IsOPSDrug").IsOptional().HasColumnType("bit");
            Property(x => x.IsUseDrug).HasColumnName(@"IsUseDrug").IsOptional().HasColumnType("bit");
            Property(x => x.LsInfectRange).HasColumnName(@"LsInfectRange").IsOptional().HasColumnType("smallint");
            Property(x => x.LsUseType).HasColumnName(@"LsUseType").IsOptional().HasColumnType("smallint");
            Property(x => x.LsUnionDrug).HasColumnName(@"LsUnionDrug").IsOptional().HasColumnType("smallint");
            Property(x => x.LsUsePurpose).HasColumnName(@"LsUsePurpose").IsOptional().HasColumnType("smallint");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
        }
    }
}
