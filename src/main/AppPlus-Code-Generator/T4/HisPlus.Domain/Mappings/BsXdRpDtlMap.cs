using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsXdRpDtlMap : EntityTypeConfiguration<BsXdRpDtl>
    {
        public BsXdRpDtlMap()
            : this("dbo")
        {
        }

        public BsXdRpDtlMap(string schema)
        {
            ToTable("BsXdRpDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.XdRpId).HasColumnName(@"XdRpId").IsRequired().HasColumnType("int");
            Property(x => x.GroupNum).HasColumnName(@"GroupNum").IsRequired().HasColumnType("smallint");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.Dosage).HasColumnName(@"Dosage").IsRequired().HasColumnType("decimal").HasPrecision(10,4);
            Property(x => x.UnitTakeId).HasColumnName(@"UnitTakeId").IsOptional().HasColumnType("int");
            Property(x => x.FrequencyId).HasColumnName(@"FrequencyId").IsOptional().HasColumnType("int");
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsOptional().HasColumnType("int");
            Property(x => x.Days).HasColumnName(@"Days").IsOptional().HasColumnType("smallint");
            Property(x => x.ExecLocId).HasColumnName(@"ExecLocId").IsOptional().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.FeeTotality).HasColumnName(@"FeeTotality").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsOptional().HasColumnType("int");
        }
    }
}
