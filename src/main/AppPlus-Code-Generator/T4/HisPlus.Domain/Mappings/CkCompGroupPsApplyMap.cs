using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkCompGroupPsApplyMap : EntityTypeConfiguration<CkCompGroupPsApply>
    {
        public CkCompGroupPsApplyMap()
            : this("dbo")
        {
        }

        public CkCompGroupPsApplyMap(string schema)
        {
            ToTable("CkCompGroupPsApply", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.XType).HasColumnName(@"XType").IsRequired().HasColumnType("smallint");
            Property(x => x.IsPre).HasColumnName(@"IsPre").IsRequired().HasColumnType("bit");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsOptional().HasColumnType("int");
            Property(x => x.ApplyMemo).HasColumnName(@"ApplyMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Summary).HasColumnName(@"Summary").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Diagnose).HasColumnName(@"Diagnose").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.CompGroupId).HasColumnName(@"CompGroupId").IsOptional().HasColumnType("int");
        }
    }
}
