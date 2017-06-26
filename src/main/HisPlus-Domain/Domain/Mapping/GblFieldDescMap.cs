using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblFieldDescMap : EntityTypeConfiguration<GblFieldDesc>
    {
        public GblFieldDescMap()
            : this("dbo")
        {
        }

        public GblFieldDescMap(string schema)
        {
            ToTable("GblFieldDesc", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TableName).HasColumnName(@"TableName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.FieldName).HasColumnName(@"FieldName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Description).HasColumnName(@"Description").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
