using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class EqCheckMap : EntityTypeConfiguration<EqCheck>
    {
        public EqCheckMap()
            : this("dbo")
        {
        }

        public EqCheckMap(string schema)
        {
            ToTable("EqCheck", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.EquipmentId).HasColumnName(@"EquipmentId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(12);
            Property(x => x.CheckTime).HasColumnName(@"CheckTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.CheckMan).HasColumnName(@"CheckMan").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Result).HasColumnName(@"Result").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.F1).HasColumnName(@"F1").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
