using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblSettingMap : EntityTypeConfiguration<GblSetting>
    {
        public GblSettingMap()
            : this("dbo")
        {
        }

        public GblSettingMap(string schema)
        {
            ToTable("GblSetting", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.KeyNum).HasColumnName(@"KeyNum").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.SetValue).HasColumnName(@"SetValue").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Explain).HasColumnName(@"Explain").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
        }
    }
}
