using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblEmailUserMap : EntityTypeConfiguration<GblEmailUser>
    {
        public GblEmailUserMap()
            : this("dbo")
        {
        }

        public GblEmailUserMap(string schema)
        {
            ToTable("GblEmailUser", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.EmailId).HasColumnName(@"EmailId").IsRequired().HasColumnType("int");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.IsRead).HasColumnName(@"IsRead").IsOptional().HasColumnType("bit");
            Property(x => x.ReadTime).HasColumnName(@"ReadTime").IsOptional().HasColumnType("smalldatetime");
        }
    }
}
