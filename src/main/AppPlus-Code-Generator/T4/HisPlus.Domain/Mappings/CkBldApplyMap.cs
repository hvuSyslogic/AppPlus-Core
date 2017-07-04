using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkBldApplyMap : EntityTypeConfiguration<CkBldApply>
    {
        public CkBldApplyMap()
            : this("dbo")
        {
        }

        public CkBldApplyMap(string schema)
        {
            ToTable("CkBldApply", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RecNo).HasColumnName(@"RecNo").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(12);
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.PatBloodGroup).HasColumnName(@"PatBloodGroup").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.PatRhd).HasColumnName(@"PatRHD").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Illness).HasColumnName(@"Illness").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Purpose).HasColumnName(@"Purpose").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.HstyBlood).HasColumnName(@"HstyBlood").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.HstyReact).HasColumnName(@"HstyReact").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.HstyTest).HasColumnName(@"HstyTest").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.HstyPregnancy).HasColumnName(@"HstyPregnancy").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.HstyBirth).HasColumnName(@"HstyBirth").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.TestResult).HasColumnName(@"TestResult").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.BloodTypeId).HasColumnName(@"BloodTypeId").IsOptional().HasColumnType("int");
            Property(x => x.Vollume).HasColumnName(@"Vollume").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.Unit).HasColumnName(@"Unit").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PreOps).HasColumnName(@"PreOps").IsOptional().HasColumnType("decimal");
            Property(x => x.SpecHandle).HasColumnName(@"SpecHandle").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.BloodGroup).HasColumnName(@"BloodGroup").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.Replace).HasColumnName(@"Replace").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LabNum).HasColumnName(@"LabNum").IsOptional().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.IsAgree).HasColumnName(@"IsAgree").IsOptional().HasColumnType("bit");
        }
    }
}
