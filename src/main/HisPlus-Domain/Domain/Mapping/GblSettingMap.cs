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
            Property(x => x.Piority).HasColumnName(@"Piority").IsOptional().HasColumnType("smallint");
            Property(x => x.Basetable).HasColumnName(@"Basetable").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsMutiselect).HasColumnName(@"IsMutiselect").IsOptional().HasColumnType("bit");
            Property(x => x.SystemId).HasColumnName(@"SystemId").IsOptional().HasColumnType("int");
            Property(x => x.ModiTime).HasColumnName(@"ModiTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ModiOperId).HasColumnName(@"ModiOperId").IsOptional().HasColumnType("int");
        }
    }
}
