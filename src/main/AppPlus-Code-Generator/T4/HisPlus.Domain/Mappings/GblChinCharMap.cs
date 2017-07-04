using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblChinCharMap : EntityTypeConfiguration<GblChinChar>
    {
        public GblChinCharMap()
            : this("dbo")
        {
        }

        public GblChinCharMap(string schema)
        {
            ToTable("GblChinChar", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.PyChar).HasColumnName(@"PyChar").IsRequired().HasColumnType("nvarchar").HasMaxLength(5);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.WbChar).HasColumnName(@"WbChar").IsRequired().HasColumnType("nvarchar").HasMaxLength(5);
        }
    }
}
