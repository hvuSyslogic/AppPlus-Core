using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblGetSequenceNumMap : EntityTypeConfiguration<GblGetSequenceNum>
    {
        public GblGetSequenceNumMap()
            : this("dbo")
        {
        }

        public GblGetSequenceNumMap(string schema)
        {
            ToTable("GblGetSequenceNum", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NextSequenceNum).HasColumnName(@"NextSequenceNum").IsRequired().HasColumnType("bigint");
            Property(x => x.IsDayBegin).HasColumnName(@"IsDayBegin").IsRequired().HasColumnType("bit");
            Property(x => x.GetdateStr).HasColumnName(@"GetdateStr").IsOptional().HasColumnType("nvarchar").HasMaxLength(8).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.NextSequenceStr).HasColumnName(@"NextSequenceStr").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(16).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }
}
