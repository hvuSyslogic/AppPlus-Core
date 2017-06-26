using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class DgIllXdRpMap : EntityTypeConfiguration<DgIllXdRp>
    {
        public DgIllXdRpMap()
            : this("dbo")
        {
        }

        public DgIllXdRpMap(string schema)
        {
            ToTable("DgIllXdRp", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IllId).HasColumnName(@"IllId").IsOptional().HasColumnType("int");
            Property(x => x.XdRpId).HasColumnName(@"XdRpId").IsRequired().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
        }
    }
}
