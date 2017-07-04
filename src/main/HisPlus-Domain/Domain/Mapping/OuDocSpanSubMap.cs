using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuDocSpanSubMap : EntityTypeConfiguration<OuDocSpanSub>
    {
        public OuDocSpanSubMap()
            : this("dbo")
        {
        }

        public OuDocSpanSubMap(string schema)
        {
            ToTable("OuDocSpanSub", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Weekplanid).HasColumnName(@"weekplanid").IsOptional().HasColumnType("int");
            Property(x => x.Spanlimitnum).HasColumnName(@"spanlimitnum").IsOptional().HasColumnType("int");
            Property(x => x.Sublimitnum).HasColumnName(@"sublimitnum").IsOptional().HasColumnType("int");
            Property(x => x.Timespansubid).HasColumnName(@"timespansubid").IsOptional().HasColumnType("int");
        }
    }
}
