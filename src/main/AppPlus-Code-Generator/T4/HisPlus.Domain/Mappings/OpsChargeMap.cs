using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OpsChargeMap : EntityTypeConfiguration<OpsCharge>
    {
        public OpsChargeMap()
            : this("dbo")
        {
        }

        public OpsChargeMap(string schema)
        {
            ToTable("OpsCharge", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ApplyId).HasColumnName(@"ApplyId").IsRequired().HasColumnType("int");
            Property(x => x.ListNum).HasColumnName(@"ListNum").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.Remark).HasColumnName(@"Remark").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.IsTally).HasColumnName(@"IsTally").IsRequired().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Before).HasColumnName(@"Before").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Progress).HasColumnName(@"Progress").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.After).HasColumnName(@"After").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
        }
    }
}
