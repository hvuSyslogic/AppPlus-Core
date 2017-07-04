using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsRegTimeSpanMap : EntityTypeConfiguration<BsRegTimeSpan>
    {
        public BsRegTimeSpanMap()
            : this("dbo")
        {
        }

        public BsRegTimeSpanMap(string schema)
        {
            ToTable("BsRegTimeSpan", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(2);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.TimeBegin).HasColumnName(@"TimeBegin").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(5);
            Property(x => x.TimeEnd).HasColumnName(@"TimeEnd").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(5);
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
        }
    }
}
