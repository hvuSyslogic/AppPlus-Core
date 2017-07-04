using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkBloodBackMap : EntityTypeConfiguration<CkBloodBack>
    {
        public CkBloodBackMap()
            : this("dbo")
        {
        }

        public CkBloodBackMap(string schema)
        {
            ToTable("CkBloodBack", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RecNo).HasColumnName(@"RecNo").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(12);
            Property(x => x.LabId).HasColumnName(@"LabId").IsRequired().HasColumnType("int");
            Property(x => x.BloodId).HasColumnName(@"BloodId").IsRequired().HasColumnType("int");
            Property(x => x.BackTime).HasColumnName(@"BackTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.BackOperId).HasColumnName(@"BackOperId").IsOptional().HasColumnType("int");
            Property(x => x.BackReason).HasColumnName(@"BackReason").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
        }
    }
}
