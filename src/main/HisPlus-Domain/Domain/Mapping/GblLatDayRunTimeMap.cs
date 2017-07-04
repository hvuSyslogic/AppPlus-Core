using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblLatDayRunTimeMap : EntityTypeConfiguration<GblLatDayRunTime>
    {
        public GblLatDayRunTimeMap()
            : this("dbo")
        {
        }

        public GblLatDayRunTimeMap(string schema)
        {
            ToTable("GblLatDayRunTime", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LastTime).HasColumnName(@"LastTime").IsOptional().HasColumnType("datetime");
        }
    }
}
