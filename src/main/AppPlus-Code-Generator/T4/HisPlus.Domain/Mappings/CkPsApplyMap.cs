using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkPsApplyMap : EntityTypeConfiguration<CkPsApply>
    {
        public CkPsApplyMap()
            : this("dbo")
        {
        }

        public CkPsApplyMap(string schema)
        {
            ToTable("CkPsApply", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ApplyId).HasColumnName(@"ApplyId").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CheckId).HasColumnName(@"CheckId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.CheckBody).HasColumnName(@"CheckBody").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.XType).HasColumnName(@"XType").IsRequired().HasColumnType("smallint");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
