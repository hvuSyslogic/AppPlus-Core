using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblFuctionMap : EntityTypeConfiguration<GblFuction>
    {
        public GblFuctionMap()
            : this("dbo")
        {
        }

        public GblFuctionMap(string schema)
        {
            ToTable("GblFuction", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MenuId).HasColumnName(@"MenuId").IsOptional().HasColumnType("int");
            Property(x => x.Title).HasColumnName(@"Title").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Content).HasColumnName(@"Content").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.IsTest).HasColumnName(@"IsTest").IsOptional().HasColumnType("bit");
            Property(x => x.LsClass).HasColumnName(@"LsClass").IsOptional().HasColumnType("smallint");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("int");
            Property(x => x.Code).HasColumnName(@"Code").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(10);
        }
    }
}
