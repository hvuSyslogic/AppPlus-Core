using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsRegSpanSubMap : EntityTypeConfiguration<BsRegSpanSub>
    {
        public BsRegSpanSubMap()
            : this("dbo")
        {
        }

        public BsRegSpanSubMap(string schema)
        {
            ToTable("BsRegSpanSub", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(2);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.TimeBegin).HasColumnName(@"TimeBegin").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(5);
            Property(x => x.TimeEnd).HasColumnName(@"TimeEnd").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(5);
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.TimeSpanId).HasColumnName(@"TimeSpanId").IsOptional().HasColumnType("int");
        }
    }
}
