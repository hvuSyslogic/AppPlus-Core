using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class EqRepairMap : EntityTypeConfiguration<EqRepair>
    {
        public EqRepairMap()
            : this("dbo")
        {
        }

        public EqRepairMap(string schema)
        {
            ToTable("EqRepair", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.EquipmentId).HasColumnName(@"EquipmentId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(12);
            Property(x => x.RepairTime).HasColumnName(@"RepairTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.Reason).HasColumnName(@"Reason").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.RepairWay).HasColumnName(@"RepairWay").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.RepairUnit).HasColumnName(@"RepairUnit").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.RepairMan).HasColumnName(@"RepairMan").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.RepairFee).HasColumnName(@"RepairFee").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.F1).HasColumnName(@"F1").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
