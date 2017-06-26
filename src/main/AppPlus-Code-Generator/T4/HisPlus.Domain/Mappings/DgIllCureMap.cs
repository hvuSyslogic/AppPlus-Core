using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class DgIllCureMap : EntityTypeConfiguration<DgIllCure>
    {
        public DgIllCureMap()
            : this("dbo")
        {
        }

        public DgIllCureMap(string schema)
        {
            ToTable("DgIllCure", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IllId).HasColumnName(@"IllId").IsOptional().HasColumnType("int");
            Property(x => x.IllGroupId).HasColumnName(@"IllGroupId").IsOptional().HasColumnType("int");
            Property(x => x.CureId).HasColumnName(@"CureId").IsOptional().HasColumnType("int");
            Property(x => x.DrugId).HasColumnName(@"DrugId").IsOptional().HasColumnType("int");
            Property(x => x.CheckId).HasColumnName(@"CheckId").IsOptional().HasColumnType("int");
            Property(x => x.NurseId).HasColumnName(@"NurseId").IsOptional().HasColumnType("int");
            Property(x => x.LsAdvType).HasColumnName(@"LsAdvType").IsOptional().HasColumnType("smallint");
            Property(x => x.LsCureType).HasColumnName(@"LsCureType").IsOptional().HasColumnType("smallint");
            Property(x => x.IsBaby).HasColumnName(@"IsBaby").IsOptional().HasColumnType("bit");
            Property(x => x.IsWomen).HasColumnName(@"IsWomen").IsOptional().HasColumnType("bit");
            Property(x => x.IsMen).HasColumnName(@"IsMen").IsOptional().HasColumnType("bit");
            Property(x => x.IsOlder).HasColumnName(@"IsOlder").IsOptional().HasColumnType("bit");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.Dosage).HasColumnName(@"Dosage").IsOptional().HasColumnType("decimal").HasPrecision(10,4);
            Property(x => x.UnitTakeId).HasColumnName(@"UnitTakeId").IsOptional().HasColumnType("int");
            Property(x => x.FrequencyId).HasColumnName(@"FrequencyId").IsOptional().HasColumnType("int");
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsOptional().HasColumnType("int");
            Property(x => x.Days).HasColumnName(@"Days").IsOptional().HasColumnType("smallint");
            Property(x => x.FeeTotality).HasColumnName(@"FeeTotality").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsOptional().HasColumnType("int");
        }
    }
}
