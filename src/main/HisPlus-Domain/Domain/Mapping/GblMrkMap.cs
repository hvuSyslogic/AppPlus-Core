using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblMrkMap : EntityTypeConfiguration<GblMrk>
    {
        public GblMrkMap()
            : this("dbo")
        {
        }

        public GblMrkMap(string schema)
        {
            ToTable("GblMrk", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MrkFile).HasColumnName(@"MrkFile").IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.MrkContent).HasColumnName(@"MrkContent").IsOptional().IsUnicode(false).HasColumnType("text").HasMaxLength(2147483647);
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
        }
    }
}
