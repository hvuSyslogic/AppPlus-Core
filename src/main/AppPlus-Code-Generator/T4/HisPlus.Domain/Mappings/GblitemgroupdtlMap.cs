using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblitemgroupdtlMap : EntityTypeConfiguration<Gblitemgroupdtl>
    {
        public GblitemgroupdtlMap()
            : this("dbo")
        {
        }

        public GblitemgroupdtlMap(string schema)
        {
            ToTable("GBLITEMGROUPDTL", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Groupid).HasColumnName(@"GROUPID").IsRequired().HasColumnType("int");
            Property(x => x.Itemid).HasColumnName(@"ITEMID").IsRequired().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
