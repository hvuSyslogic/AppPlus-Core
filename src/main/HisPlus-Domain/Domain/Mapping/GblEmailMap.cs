using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblEmailMap : EntityTypeConfiguration<GblEmail>
    {
        public GblEmailMap()
            : this("dbo")
        {
        }

        public GblEmailMap(string schema)
        {
            ToTable("GblEmail", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Title).HasColumnName(@"Title").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Content).HasColumnName(@"Content").IsRequired().HasColumnType("nvarchar").HasMaxLength(4000);
            Property(x => x.FileName).HasColumnName(@"FileName").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.IsSign).HasColumnName(@"IsSign").IsRequired().HasColumnType("bit");
            Property(x => x.IsPriority).HasColumnName(@"IsPriority").IsRequired().HasColumnType("bit");
        }
    }
}
